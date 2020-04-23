using System;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using combit.ListLabel24;

namespace Askona_IKEA_Label
{
    public partial class FormMain : Form
    {
        private ListLabel LL;
        public FormMain() => InitializeComponent();

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                LL = new ListLabel
                {
                    LicensingInfo = "PMh4Gg",
                    MaxRTFVersion = 65280,
                    PreviewControl = null,
                    Unit = LlUnits.Millimeter_1_100,
                    DataSource = new List<string> { "" }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найдены библиотеки для печати (combit.ListLabel)!\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            YearTB.Text = DateTime.Now.Year.ToString().Substring(2, 2);
            WeekTB.Text = WeekNumber(DateTime.Now).ToString();
            LabelTypeCB.Items.Add("NLRJ (85 на 125 мм)");
            LabelTypeCB.Items.Add("NLE (36.6 на 250 мм)");
            LabelTypeCB.Items.Add("NLE mini (82 на 17 мм)");
            LabelTypeCB.Items.Add("FP (85 на 125 мм)");
            LabelTypeCB.Items.Add("MDQ (105 на 55 мм)");
            LabelTypeCB.Items.Add("LCI детские (80 на 50 мм)");
            LabelTypeCB.Items.Add("LCI прочие (50 на 95 мм)");
            LabelTypeCB.Items.Add("2 паллеты (57 на 110 мм)");
            LabelTypeCB.Items.Add("NLACD (35 на 280 мм)");
            LabelTypeCB.Items.Add("MAM1 (104 на 130 мм)");
            LabelTypeCB.Items.Add("MAM2 (104 на 226 мм)");
            LabelTypeCB.Items.Add("MAM3 (104 на 328 мм)");
            LabelTypeCB.Items.Add("MAM4 (104 на 369 мм)");
            LabelTypeCB.Items.Add("MAM5 (104 на 455 мм)");
            LabelTypeCB.Items.Add("MAM6 (104 на 527 мм)");
            LabelTypeCB.Items.Add("NLB (17 на 196 мм)");
            LabelTypeCB.Items.Add("MAM7 (104 на 100 мм)");
            LabelTypeCB.Items.Add("MAM8 (104 на 155 мм)");
            LabelTypeCB.Items.Add("MAM9 (104 на 200 мм)");
            LabelTypeCB.Items.Add("MAM10 (104 на 265 мм)");
            LabelTypeCB.Items.Add("MAM11 (104 на 310 мм)");
            LabelTypeCB.Items.Add("MAM12 (104 на 355 мм)");
            LabelTypeCB.Items.Add("MAM13 (104 на 410 мм)");
            LabelTypeCB.SelectedIndex = 0;
            DriveTreeInit(); //инициализация дерева
        }

        //инициализация окна древовидного списка дисковых устройств
        private void DriveTreeInit()
        {
            CatalogTV.BeginUpdate();
            CatalogTV.Nodes.Clear();
            try
            {
                string TEMPLATEPATH = ConfigurationManager.AppSettings["TEMPLATEPATH"];
                DirectoryInfo dir = new DirectoryInfo(TEMPLATEPATH);
                TreeNode tn = new TreeNode(dir.FullName, 0, 0);
                CatalogTV.Nodes.Add(tn);
                GetDirs(tn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки настроек или дерева!\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CatalogTV.EndUpdate();
            }
        }

        //получение списка каталогов
        private void GetDirs(TreeNode node)
        {
            DirectoryInfo[] diArray;
            node.Nodes.Clear();
            string fullPath = node.FullPath;
            DirectoryInfo di = new DirectoryInfo(fullPath);
            try
            {
                diArray = di.GetDirectories(); //сохраняем содержимое каталога
            }
            catch
            {
                return;
            }
            //содержимое массива diArray используется для заполнения узла дерева содержимым каталога
            foreach (DirectoryInfo dirinfo in diArray)
            {
                TreeNode dir = new TreeNode(dirinfo.Name, 1, 1);
                node.Nodes.Add(dir);
            }
        }

        //обработчик события раскрытия узла дерева
        private void CatalogTV_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            CatalogTV.BeginUpdate();
            foreach (TreeNode node in e.Node.Nodes)
                GetDirs(node);
            CatalogTV.EndUpdate();
        }

        private void CatalogTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node; //ссылка на выделенный узел дерева
            string fullPath = selectedNode.FullPath; //полный путь к выделенному узлу
            //получаем списки всех файлов и каталогов, располагающихся в каталоге, выделенном в дереве
            DirectoryInfo di = new DirectoryInfo(fullPath);
            FileInfo[] fiArray;
            DirectoryInfo[] diArray;
            try
            {
                fiArray = di.GetFiles("*.jpg"); //перечень файлов .jpg
                diArray = di.GetDirectories(); //перечень каталогов
            }
            catch
            {
                return;
            }
            FileLV.Items.Clear();
            //наполнение списка ListView именами каталогов
            foreach (DirectoryInfo dirInfo in diArray)
            {
                ListViewItem lvi = new ListViewItem(dirInfo.Name); //создаем элемент списка
                lvi.SubItems.Add("0"); //атрибут "Размер" = 0
                lvi.SubItems.Add(dirInfo.LastWriteTime.ToString()); //атрибут "Изменен"
                lvi.Tag = dirInfo.FullName;
                lvi.ImageIndex = 0; //индекс значка
                FileLV.Items.Add(lvi); //добавление в список
            }
            //наполнение списка ListView именами файлов
            foreach (FileInfo fileInfo in fiArray)
            {
                ListViewItem lvi = new ListViewItem(fileInfo.Name); //создаем элемент списка
                lvi.SubItems.Add(fileInfo.Length.ToString()); //атрибут "Размер"
                lvi.SubItems.Add(fileInfo.LastWriteTime.ToString()); //атрибут "Изменен"
                lvi.Tag = fileInfo.FullName;
                //определяем тип текущего файла
                //string filenameExtension = Path.GetExtension(fileInfo.Name).ToLower();
                lvi.ImageIndex = 1;
                FileLV.Items.Add(lvi); //добавление в список
            }
        }

        private string SelectLabelType()
        {
            string labelType = "";
            switch (LabelTypeCB.SelectedIndex)
            {
                case 0:
                    labelType = "NLRJ";
                    break;
                case 1:
                    labelType = "NLE";
                    break;
                case 2:
                    labelType = "NLE_mini";
                    break;
                case 3:
                    labelType = "FP";
                    break;
                case 4:
                    labelType = "MDQ";
                    break;
                case 5:
                    labelType = "LCI_детские";
                    break;
                case 6:
                    labelType = "LCI_прочие";
                    break;
                case 7:
                    labelType = "2_паллеты";
                    break;
                case 8:
                    labelType = "NLACD";
                    break;
                case 9:
                    labelType = "MAM1";
                    break;
                case 10:
                    labelType = "MAM2";
                    break;
                case 11:
                    labelType = "MAM3";
                    break;
                case 12:
                    labelType = "MAM4";
                    break;
                case 13:
                    labelType = "MAM5";
                    break;
                case 14:
                    labelType = "MAM6";
                    break;
                case 15:
                    labelType = "NLB";
                    break;
                case 16:
                    labelType = "MAM7";
                    break;
                case 17:
                    labelType = "MAM8";
                    break;
                case 18:
                    labelType = "MAM9";
                    break;
                case 19:
                    labelType = "MAM10";
                    break;
                case 20:
                    labelType = "MAM11";
                    break;
                case 21:
                    labelType = "MAM12";
                    break;
                case 22:
                    labelType = "MAM13";
                    break;
            }
            return labelType;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                LL_DefineVariables();
                if (FileLV.SelectedItems[0].Tag.ToString().IndexOf(".jpg") > 0)
                {
                    string labelType = SelectLabelType();
                    if (labelType == "NLB")
                        LL.Print(0, LlProject.Label, Application.StartupPath + "\\Шаблоны\\NLB.lbl", false, LlPrintMode.Export, LlBoxType.EmptyWait, this.Handle, "Печать", true, "");
                    else
                        if (labelType == "NLE")
                            LL.Print(0, LlProject.Label, Application.StartupPath + "\\Шаблоны\\NLE.lbl", false, LlPrintMode.Export, LlBoxType.EmptyWait, this.Handle, "Печать", true, "");
                        else
                            if (labelType == "NLACD")
                                LL.Print(0, LlProject.Label, Application.StartupPath + "\\Шаблоны\\NLACD.lbl", false, LlPrintMode.Export, LlBoxType.EmptyWait, this.Handle, "Печать", true, "");
                            else
                                if (labelType == "LCI_прочие")
                                    LL.Print(0, LlProject.Label, Application.StartupPath + "\\Шаблоны\\LCI_прочие.lbl", false, LlPrintMode.Export, LlBoxType.EmptyWait, this.Handle, "Печать", true, "");
                                else
                                    LL.Print(0, LlProject.Label, Application.StartupPath + "\\Шаблоны\\ИКЕА_общая.lbl", false, LlPrintMode.Export, LlBoxType.EmptyWait, this.Handle, "Печать", true, "");
                }
            }
            catch (LL_User_Aborted_Exception)
            { }
            catch (Exception LLException)
            {
                MessageBox.Show("Ошибка печати.\n\n" + LLException.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MiDesign_Click(object sender, EventArgs e)
        {
            try
            {
                LL_DefineVariables();
                if (FileLV.SelectedItems[0].Tag.ToString().IndexOf(".jpg") > 0)
                {
                    string labelType = SelectLabelType();
                    if (labelType == "NLB")
                        LL.Design(0, this.Handle, "Открытие шаблона", LlProject.Label | LlProject.FileAlsoNew, Application.StartupPath + "\\Шаблоны\\NLB.lbl", true);
                    else
                        if (labelType == "NLE")
                            LL.Design(0, this.Handle, "Открытие шаблона", LlProject.Label | LlProject.FileAlsoNew, Application.StartupPath + "\\Шаблоны\\NLE.lbl", true);
                        else
                            if (labelType == "NLACD")
                                LL.Design(0, this.Handle, "Открытие шаблона", LlProject.Label | LlProject.FileAlsoNew, Application.StartupPath + "\\Шаблоны\\NLACD.lbl", true);
                            else
                                if (labelType == "LCI_прочие")
                                    LL.Design(0, this.Handle, "Открытие шаблона", LlProject.Label | LlProject.FileAlsoNew, Application.StartupPath + "\\Шаблоны\\LCI_прочие.lbl", true);
                                else
                                    LL.Design(0, this.Handle, "Открытие шаблона", LlProject.Label | LlProject.FileAlsoNew, Application.StartupPath + "\\Шаблоны\\ИКЕА_общая.lbl", true);
                }
            }
            catch (LL_User_Aborted_Exception)
            { }
            catch (Exception LLException)
            {
                MessageBox.Show("Ошибка дизайнера.\n\n" + LLException.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LL_DefineVariables()
        {
            LL.Variables.Add("LABELTYPE", SelectLabelType());
            LL.Variables.Add("FULLNAME", FileLV.SelectedItems[0].Tag.ToString());
            LL.Variables.Add("YEAR", Convert.ToInt32(YearTB.Text));
            LL.Variables.Add("WEEK", Convert.ToInt32(WeekTB.Text));
            LL.Variables.Add("CURDATE", DateDTP.Value.ToShortDateString());
        }

        public int WeekNumber(DateTime fromDate)
        {
            // Получаем 1 января указанного нами года
            DateTime startOfYear = fromDate.AddDays(-fromDate.Day + 1).AddMonths(-fromDate.Month + 1);
            // Получение 31 декабря указанного нами года
            DateTime endOfYear = startOfYear.AddYears(1).AddDays(-1);
            //Согласно ISO 8601 четверг считается четвёртым днём недели, а также днём, который определяет нумерацию недель: 
            //первая неделя года определяется как неделя, содержащая первый четверг года, и так далее.
            int[] iso8601Correction = { 6, 7, 8, 9, 10, 4, 5 };
            int nds = fromDate.Subtract(startOfYear).Days +
            iso8601Correction[(int)startOfYear.DayOfWeek];
            int wk = nds / 7;
            switch (wk)
            {
                case 0:
                    // Возвращаем номер недели от 31 декабря предыдущего года
                    return WeekNumber(startOfYear.AddDays(-1));
                case 53:
                    // Если 31 декабря выпадает до четверга 1 недели следующего года                    
                    if (endOfYear.DayOfWeek < DayOfWeek.Thursday)
                        return 1;
                    else
                        return wk;
                default: return wk;
            }
        }
    }
}