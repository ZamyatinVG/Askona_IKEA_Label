namespace Askona_IKEA_Label
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.CatalogTV = new System.Windows.Forms.TreeView();
            this.TreeIcon = new System.Windows.Forms.ImageList(this.components);
            this.FileLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListIcon = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miDesign = new System.Windows.Forms.ToolStripMenuItem();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearTB = new System.Windows.Forms.TextBox();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.WeekTB = new System.Windows.Forms.TextBox();
            this.LabelTypeCB = new System.Windows.Forms.ComboBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CatalogTV
            // 
            this.CatalogTV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatalogTV.ImageIndex = 0;
            this.CatalogTV.ImageList = this.TreeIcon;
            this.CatalogTV.Location = new System.Drawing.Point(12, 58);
            this.CatalogTV.Name = "CatalogTV";
            this.CatalogTV.SelectedImageIndex = 1;
            this.CatalogTV.Size = new System.Drawing.Size(300, 369);
            this.CatalogTV.TabIndex = 2;
            this.CatalogTV.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.CatalogTV_BeforeExpand);
            this.CatalogTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CatalogTV_AfterSelect);
            // 
            // TreeIcon
            // 
            this.TreeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeIcon.ImageStream")));
            this.TreeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeIcon.Images.SetKeyName(0, "FolderIcon.ico");
            this.TreeIcon.Images.SetKeyName(1, "FolderIconCopy.ico");
            // 
            // FileLV
            // 
            this.FileLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.FileLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileLV.HideSelection = false;
            this.FileLV.Location = new System.Drawing.Point(318, 30);
            this.FileLV.MultiSelect = false;
            this.FileLV.Name = "FileLV";
            this.FileLV.Size = new System.Drawing.Size(500, 397);
            this.FileLV.SmallImageList = this.ListIcon;
            this.FileLV.TabIndex = 3;
            this.FileLV.UseCompatibleStateImageBehavior = false;
            this.FileLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 258;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Размер";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Изменен";
            this.columnHeader3.Width = 150;
            // 
            // ListIcon
            // 
            this.ListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListIcon.ImageStream")));
            this.ListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ListIcon.Images.SetKeyName(0, "FolderIcon.ico");
            this.ListIcon.Images.SetKeyName(1, "JpgIcon.ico");
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(830, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "MainMenu";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDesign});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // miDesign
            // 
            this.miDesign.Name = "miDesign";
            this.miDesign.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.miDesign.Size = new System.Drawing.Size(164, 22);
            this.miDesign.Text = "Дизайнер";
            this.miDesign.Visible = false;
            this.miDesign.Click += new System.EventHandler(this.MiDesign_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLabel.Location = new System.Drawing.Point(12, 33);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(31, 15);
            this.YearLabel.TabIndex = 7;
            this.YearLabel.Text = "Год:";
            // 
            // YearTB
            // 
            this.YearTB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearTB.Location = new System.Drawing.Point(43, 30);
            this.YearTB.Name = "YearTB";
            this.YearTB.Size = new System.Drawing.Size(30, 22);
            this.YearTB.TabIndex = 8;
            this.YearTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeekLabel.Location = new System.Drawing.Point(75, 33);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(53, 15);
            this.WeekLabel.TabIndex = 9;
            this.WeekLabel.Text = "Неделя:";
            // 
            // WeekTB
            // 
            this.WeekTB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeekTB.Location = new System.Drawing.Point(128, 30);
            this.WeekTB.Name = "WeekTB";
            this.WeekTB.Size = new System.Drawing.Size(30, 22);
            this.WeekTB.TabIndex = 9;
            this.WeekTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelTypeCB
            // 
            this.LabelTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LabelTypeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTypeCB.FormattingEnabled = true;
            this.LabelTypeCB.Location = new System.Drawing.Point(12, 438);
            this.LabelTypeCB.Name = "LabelTypeCB";
            this.LabelTypeCB.Size = new System.Drawing.Size(650, 39);
            this.LabelTypeCB.TabIndex = 11;
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.Location = new System.Drawing.Point(668, 436);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(150, 41);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(160, 33);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 15);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = "Дата:";
            // 
            // DateDTP
            // 
            this.DateDTP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateDTP.Location = new System.Drawing.Point(200, 30);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(112, 22);
            this.DateDTP.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 489);
            this.Controls.Add(this.DateDTP);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.LabelTypeCB);
            this.Controls.Add(this.WeekTB);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.YearTB);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.FileLV);
            this.Controls.Add(this.CatalogTV);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать этикеток IKEA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView CatalogTV;
        private System.Windows.Forms.ListView FileLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ImageList ListIcon;
        private System.Windows.Forms.ImageList TreeIcon;
        
        private System.Windows.Forms.ToolStripMenuItem miDesign;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox YearTB;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.TextBox WeekTB;
        private System.Windows.Forms.ComboBox LabelTypeCB;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DateDTP;
    }
}

