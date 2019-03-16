namespace MultipleChoiceTool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Tb_UserName = new System.Windows.Forms.TextBox();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.Btm_Exit = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Br_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(27, 43);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(138, 24);
            this.Lbl_UserName.TabIndex = 0;
            this.Lbl_UserName.Text = "Benutzername:";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(27, 110);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(93, 24);
            this.Lbl_Password.TabIndex = 1;
            this.Lbl_Password.Text = "Passwort:";
            // 
            // Tb_UserName
            // 
            this.Tb_UserName.Location = new System.Drawing.Point(225, 37);
            this.Tb_UserName.Name = "Tb_UserName";
            this.Tb_UserName.Size = new System.Drawing.Size(179, 30);
            this.Tb_UserName.TabIndex = 2;
            // 
            // Tb_Password
            // 
            this.Tb_Password.Location = new System.Drawing.Point(225, 104);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.PasswordChar = '*';
            this.Tb_Password.Size = new System.Drawing.Size(179, 30);
            this.Tb_Password.TabIndex = 3;
            // 
            // Btm_Exit
            // 
            this.Btm_Exit.Location = new System.Drawing.Point(154, 209);
            this.Btm_Exit.Name = "Btm_Exit";
            this.Btm_Exit.Size = new System.Drawing.Size(122, 35);
            this.Btm_Exit.TabIndex = 4;
            this.Btm_Exit.Text = "Beenden";
            this.Btm_Exit.UseVisualStyleBackColor = true;
            this.Btm_Exit.Click += new System.EventHandler(this.Btm_Exit_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(282, 209);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(122, 35);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Br_Register
            // 
            this.Br_Register.Location = new System.Drawing.Point(282, 168);
            this.Br_Register.Name = "Br_Register";
            this.Br_Register.Size = new System.Drawing.Size(122, 35);
            this.Br_Register.TabIndex = 6;
            this.Br_Register.Text = "Registrieren";
            this.Br_Register.UseVisualStyleBackColor = true;
            this.Br_Register.Click += new System.EventHandler(this.Br_Register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 265);
            this.Controls.Add(this.Br_Register);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Btm_Exit);
            this.Controls.Add(this.Tb_Password);
            this.Controls.Add(this.Tb_UserName);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_UserName);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple - Choice - Trainer - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Tb_UserName;
        private System.Windows.Forms.TextBox Tb_Password;
        private System.Windows.Forms.Button Btm_Exit;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Br_Register;
    }
}

