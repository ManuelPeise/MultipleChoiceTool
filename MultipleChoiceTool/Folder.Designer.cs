namespace MultipleChoiceTool
{
    partial class Folder
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
            this.Lbl_User = new System.Windows.Forms.Label();
            this.FolderChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.Tb_UserFolder = new System.Windows.Forms.TextBox();
            this.Btn_ChooseUserFolder = new System.Windows.Forms.Button();
            this.Btn_ChooseImportFolder = new System.Windows.Forms.Button();
            this.TB_TestImportFolder = new System.Windows.Forms.TextBox();
            this.Lbl_TestsImport = new System.Windows.Forms.Label();
            this.Btn_ChooseTestFolder = new System.Windows.Forms.Button();
            this.Tb_TestFolder = new System.Windows.Forms.TextBox();
            this.Lbl_Tests = new System.Windows.Forms.Label();
            this.Btn_ChooseConfigFolder = new System.Windows.Forms.Button();
            this.TB_ConfigFolder = new System.Windows.Forms.TextBox();
            this.Lbl_ConfigurationFolder = new System.Windows.Forms.Label();
            this.Btn_SaveConfig = new System.Windows.Forms.Button();
            this.Lbl_Language = new System.Windows.Forms.Label();
            this.Rb_German = new System.Windows.Forms.RadioButton();
            this.Rb_English = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Lbl_Color = new System.Windows.Forms.Label();
            this.Btn_ChooseColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Location = new System.Drawing.Point(50, 64);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(291, 27);
            this.Lbl_User.TabIndex = 0;
            this.Lbl_User.Text = "Benutzerverwaltungs-Ordner:";
            // 
            // Tb_UserFolder
            // 
            this.Tb_UserFolder.Location = new System.Drawing.Point(388, 61);
            this.Tb_UserFolder.Name = "Tb_UserFolder";
            this.Tb_UserFolder.Size = new System.Drawing.Size(283, 32);
            this.Tb_UserFolder.TabIndex = 2;
            // 
            // Btn_ChooseUserFolder
            // 
            this.Btn_ChooseUserFolder.Location = new System.Drawing.Point(740, 56);
            this.Btn_ChooseUserFolder.Name = "Btn_ChooseUserFolder";
            this.Btn_ChooseUserFolder.Size = new System.Drawing.Size(129, 42);
            this.Btn_ChooseUserFolder.TabIndex = 3;
            this.Btn_ChooseUserFolder.Text = "Wählen";
            this.Btn_ChooseUserFolder.UseVisualStyleBackColor = true;
            this.Btn_ChooseUserFolder.Click += new System.EventHandler(this.Btn_ChooseUserFolder_Click);
            // 
            // Btn_ChooseImportFolder
            // 
            this.Btn_ChooseImportFolder.Location = new System.Drawing.Point(740, 130);
            this.Btn_ChooseImportFolder.Name = "Btn_ChooseImportFolder";
            this.Btn_ChooseImportFolder.Size = new System.Drawing.Size(129, 42);
            this.Btn_ChooseImportFolder.TabIndex = 6;
            this.Btn_ChooseImportFolder.Text = "Wählen";
            this.Btn_ChooseImportFolder.UseVisualStyleBackColor = true;
            this.Btn_ChooseImportFolder.Click += new System.EventHandler(this.Btn_ChooseImportFolder_Click);
            // 
            // TB_TestImportFolder
            // 
            this.TB_TestImportFolder.Location = new System.Drawing.Point(388, 136);
            this.TB_TestImportFolder.Name = "TB_TestImportFolder";
            this.TB_TestImportFolder.Size = new System.Drawing.Size(283, 32);
            this.TB_TestImportFolder.TabIndex = 5;
            // 
            // Lbl_TestsImport
            // 
            this.Lbl_TestsImport.AutoSize = true;
            this.Lbl_TestsImport.Location = new System.Drawing.Point(50, 139);
            this.Lbl_TestsImport.Name = "Lbl_TestsImport";
            this.Lbl_TestsImport.Size = new System.Drawing.Size(201, 27);
            this.Lbl_TestsImport.TabIndex = 4;
            this.Lbl_TestsImport.Text = "Test-Import-Ordner:";
            // 
            // Btn_ChooseTestFolder
            // 
            this.Btn_ChooseTestFolder.Location = new System.Drawing.Point(740, 196);
            this.Btn_ChooseTestFolder.Name = "Btn_ChooseTestFolder";
            this.Btn_ChooseTestFolder.Size = new System.Drawing.Size(129, 42);
            this.Btn_ChooseTestFolder.TabIndex = 9;
            this.Btn_ChooseTestFolder.Text = "Wählen";
            this.Btn_ChooseTestFolder.UseVisualStyleBackColor = true;
            this.Btn_ChooseTestFolder.Click += new System.EventHandler(this.Btn_ChooseTestFolder_Click);
            // 
            // Tb_TestFolder
            // 
            this.Tb_TestFolder.Location = new System.Drawing.Point(388, 202);
            this.Tb_TestFolder.Name = "Tb_TestFolder";
            this.Tb_TestFolder.Size = new System.Drawing.Size(283, 32);
            this.Tb_TestFolder.TabIndex = 8;
            // 
            // Lbl_Tests
            // 
            this.Lbl_Tests.AutoSize = true;
            this.Lbl_Tests.Location = new System.Drawing.Point(50, 205);
            this.Lbl_Tests.Name = "Lbl_Tests";
            this.Lbl_Tests.Size = new System.Drawing.Size(123, 27);
            this.Lbl_Tests.TabIndex = 7;
            this.Lbl_Tests.Text = "Test-Ordner";
            // 
            // Btn_ChooseConfigFolder
            // 
            this.Btn_ChooseConfigFolder.Location = new System.Drawing.Point(740, 270);
            this.Btn_ChooseConfigFolder.Name = "Btn_ChooseConfigFolder";
            this.Btn_ChooseConfigFolder.Size = new System.Drawing.Size(129, 42);
            this.Btn_ChooseConfigFolder.TabIndex = 12;
            this.Btn_ChooseConfigFolder.Text = "Wählen";
            this.Btn_ChooseConfigFolder.UseVisualStyleBackColor = true;
            this.Btn_ChooseConfigFolder.Click += new System.EventHandler(this.Btn_ChooseConfigFolder_Click);
            // 
            // TB_ConfigFolder
            // 
            this.TB_ConfigFolder.Location = new System.Drawing.Point(388, 275);
            this.TB_ConfigFolder.Name = "TB_ConfigFolder";
            this.TB_ConfigFolder.Size = new System.Drawing.Size(283, 32);
            this.TB_ConfigFolder.TabIndex = 11;
            // 
            // Lbl_ConfigurationFolder
            // 
            this.Lbl_ConfigurationFolder.AutoSize = true;
            this.Lbl_ConfigurationFolder.Location = new System.Drawing.Point(50, 278);
            this.Lbl_ConfigurationFolder.Name = "Lbl_ConfigurationFolder";
            this.Lbl_ConfigurationFolder.Size = new System.Drawing.Size(217, 27);
            this.Lbl_ConfigurationFolder.TabIndex = 10;
            this.Lbl_ConfigurationFolder.Text = "Konfigurationsordner:";
            // 
            // Btn_SaveConfig
            // 
            this.Btn_SaveConfig.Location = new System.Drawing.Point(740, 469);
            this.Btn_SaveConfig.Name = "Btn_SaveConfig";
            this.Btn_SaveConfig.Size = new System.Drawing.Size(129, 42);
            this.Btn_SaveConfig.TabIndex = 13;
            this.Btn_SaveConfig.Text = "Speichern";
            this.Btn_SaveConfig.UseVisualStyleBackColor = true;
            this.Btn_SaveConfig.Click += new System.EventHandler(this.Btn_SaveConfig_Click);
            // 
            // Lbl_Language
            // 
            this.Lbl_Language.AutoSize = true;
            this.Lbl_Language.Location = new System.Drawing.Point(50, 346);
            this.Lbl_Language.Name = "Lbl_Language";
            this.Lbl_Language.Size = new System.Drawing.Size(94, 27);
            this.Lbl_Language.TabIndex = 14;
            this.Lbl_Language.Text = "Sprache:";
            // 
            // Rb_German
            // 
            this.Rb_German.AutoSize = true;
            this.Rb_German.Location = new System.Drawing.Point(388, 355);
            this.Rb_German.Name = "Rb_German";
            this.Rb_German.Size = new System.Drawing.Size(103, 31);
            this.Rb_German.TabIndex = 15;
            this.Rb_German.TabStop = true;
            this.Rb_German.Text = "Deutsch";
            this.Rb_German.UseVisualStyleBackColor = true;
            this.Rb_German.CheckedChanged += new System.EventHandler(this.Rb_German_CheckedChanged);
            // 
            // Rb_English
            // 
            this.Rb_English.AutoSize = true;
            this.Rb_English.Location = new System.Drawing.Point(388, 403);
            this.Rb_English.Name = "Rb_English";
            this.Rb_English.Size = new System.Drawing.Size(105, 31);
            this.Rb_English.TabIndex = 16;
            this.Rb_English.TabStop = true;
            this.Rb_English.Text = "Englisch";
            this.Rb_English.UseVisualStyleBackColor = true;
            this.Rb_English.CheckedChanged += new System.EventHandler(this.Rb_Enlish_CheckedChanged);
            // 
            // Lbl_Color
            // 
            this.Lbl_Color.AutoSize = true;
            this.Lbl_Color.Location = new System.Drawing.Point(50, 459);
            this.Lbl_Color.Name = "Lbl_Color";
            this.Lbl_Color.Size = new System.Drawing.Size(184, 27);
            this.Lbl_Color.TabIndex = 17;
            this.Lbl_Color.Text = "Hintergrundfarbe:";
            // 
            // Btn_ChooseColor
            // 
            this.Btn_ChooseColor.Location = new System.Drawing.Point(386, 455);
            this.Btn_ChooseColor.Name = "Btn_ChooseColor";
            this.Btn_ChooseColor.Size = new System.Drawing.Size(105, 35);
            this.Btn_ChooseColor.TabIndex = 18;
            this.Btn_ChooseColor.Text = "Wählen";
            this.Btn_ChooseColor.UseVisualStyleBackColor = true;
            this.Btn_ChooseColor.Click += new System.EventHandler(this.Btn_ChooseColor_Click);
            // 
            // Folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.Btn_ChooseColor);
            this.Controls.Add(this.Lbl_Color);
            this.Controls.Add(this.Rb_English);
            this.Controls.Add(this.Rb_German);
            this.Controls.Add(this.Lbl_Language);
            this.Controls.Add(this.Btn_SaveConfig);
            this.Controls.Add(this.Btn_ChooseConfigFolder);
            this.Controls.Add(this.TB_ConfigFolder);
            this.Controls.Add(this.Lbl_ConfigurationFolder);
            this.Controls.Add(this.Btn_ChooseTestFolder);
            this.Controls.Add(this.Tb_TestFolder);
            this.Controls.Add(this.Lbl_Tests);
            this.Controls.Add(this.Btn_ChooseImportFolder);
            this.Controls.Add(this.TB_TestImportFolder);
            this.Controls.Add(this.Lbl_TestsImport);
            this.Controls.Add(this.Btn_ChooseUserFolder);
            this.Controls.Add(this.Tb_UserFolder);
            this.Controls.Add(this.Lbl_User);
            this.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Folder";
            this.Text = "Ordner - Konfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.FolderBrowserDialog FolderChooser;
        private System.Windows.Forms.TextBox Tb_UserFolder;
        private System.Windows.Forms.Button Btn_ChooseUserFolder;
        private System.Windows.Forms.Button Btn_ChooseImportFolder;
        private System.Windows.Forms.TextBox TB_TestImportFolder;
        private System.Windows.Forms.Label Lbl_TestsImport;
        private System.Windows.Forms.Button Btn_ChooseTestFolder;
        private System.Windows.Forms.TextBox Tb_TestFolder;
        private System.Windows.Forms.Label Lbl_Tests;
        private System.Windows.Forms.Button Btn_ChooseConfigFolder;
        private System.Windows.Forms.TextBox TB_ConfigFolder;
        private System.Windows.Forms.Label Lbl_ConfigurationFolder;
        private System.Windows.Forms.Button Btn_SaveConfig;
        private System.Windows.Forms.Label Lbl_Language;
        private System.Windows.Forms.RadioButton Rb_German;
        private System.Windows.Forms.RadioButton Rb_English;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label Lbl_Color;
        private System.Windows.Forms.Button Btn_ChooseColor;
    }
}