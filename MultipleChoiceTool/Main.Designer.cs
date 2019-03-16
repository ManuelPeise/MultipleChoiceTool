namespace MultipleChoiceTool
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menue1 = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.rotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spracheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menue1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menue1
            // 
            this.Menue1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.spracheToolStripMenuItem});
            this.Menue1.Name = "Menue1";
            this.Menue1.Size = new System.Drawing.Size(90, 20);
            this.Menue1.Text = "Einstellungen";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorStandard,
            this.rotToolStripMenuItem,
            this.blauToolStripMenuItem1});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.einstellungenToolStripMenuItem.Text = "Hintergrundfarbe";
            // 
            // ColorStandard
            // 
            this.ColorStandard.Name = "ColorStandard";
            this.ColorStandard.Size = new System.Drawing.Size(180, 22);
            this.ColorStandard.Text = "‌Standart";
            this.ColorStandard.Click += new System.EventHandler(this.ColorStandard_Click);
            // 
            // rotToolStripMenuItem
            // 
            this.rotToolStripMenuItem.Name = "rotToolStripMenuItem";
            this.rotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotToolStripMenuItem.Text = "Rot";
            this.rotToolStripMenuItem.Click += new System.EventHandler(this.rotToolStripMenuItem_Click);
            // 
            // blauToolStripMenuItem1
            // 
            this.blauToolStripMenuItem1.Name = "blauToolStripMenuItem1";
            this.blauToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.blauToolStripMenuItem1.Text = "Blau";
            this.blauToolStripMenuItem1.Click += new System.EventHandler(this.blauToolStripMenuItem1_Click);
            // 
            // spracheToolStripMenuItem
            // 
            this.spracheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem,
            this.englischToolStripMenuItem});
            this.spracheToolStripMenuItem.Name = "spracheToolStripMenuItem";
            this.spracheToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spracheToolStripMenuItem.Text = "Sprache";
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deutschToolStripMenuItem.Text = "Deutsch";
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.deutschToolStripMenuItem_Click);
            // 
            // englischToolStripMenuItem
            // 
            this.englischToolStripMenuItem.Name = "englischToolStripMenuItem";
            this.englischToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englischToolStripMenuItem.Text = "Englisch";
            this.englischToolStripMenuItem.Click += new System.EventHandler(this.englischToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1103, 423);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Multiple - Choice - Trainer v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menue1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorStandard;
        private System.Windows.Forms.ToolStripMenuItem rotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spracheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem;
    }
}