namespace MultipleChoiceTool
{
    partial class Register
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
            this.Lbl_Firstname = new System.Windows.Forms.Label();
            this.Lbl_Lastname = new System.Windows.Forms.Label();
            this.Lbl_Pswd1 = new System.Windows.Forms.Label();
            this.Lbl_Pswd2 = new System.Windows.Forms.Label();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.Tb_Firstname = new System.Windows.Forms.TextBox();
            this.Tb_Lastname = new System.Windows.Forms.TextBox();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.Tb_Pswd1 = new System.Windows.Forms.TextBox();
            this.Tb_Pswd2 = new System.Windows.Forms.TextBox();
            this.Bt_Exit = new System.Windows.Forms.Button();
            this.Bt_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Firstname
            // 
            this.Lbl_Firstname.AutoSize = true;
            this.Lbl_Firstname.Location = new System.Drawing.Point(57, 47);
            this.Lbl_Firstname.Name = "Lbl_Firstname";
            this.Lbl_Firstname.Size = new System.Drawing.Size(100, 27);
            this.Lbl_Firstname.TabIndex = 0;
            this.Lbl_Firstname.Text = "Vorname:";
            // 
            // Lbl_Lastname
            // 
            this.Lbl_Lastname.AutoSize = true;
            this.Lbl_Lastname.Location = new System.Drawing.Point(53, 100);
            this.Lbl_Lastname.Name = "Lbl_Lastname";
            this.Lbl_Lastname.Size = new System.Drawing.Size(114, 27);
            this.Lbl_Lastname.TabIndex = 2;
            this.Lbl_Lastname.Text = "Nachname:";
            // 
            // Lbl_Pswd1
            // 
            this.Lbl_Pswd1.AutoSize = true;
            this.Lbl_Pswd1.Location = new System.Drawing.Point(53, 210);
            this.Lbl_Pswd1.Name = "Lbl_Pswd1";
            this.Lbl_Pswd1.Size = new System.Drawing.Size(104, 27);
            this.Lbl_Pswd1.TabIndex = 6;
            this.Lbl_Pswd1.Text = "Passwort:";
            // 
            // Lbl_Pswd2
            // 
            this.Lbl_Pswd2.AutoSize = true;
            this.Lbl_Pswd2.Location = new System.Drawing.Point(53, 261);
            this.Lbl_Pswd2.Name = "Lbl_Pswd2";
            this.Lbl_Pswd2.Size = new System.Drawing.Size(104, 27);
            this.Lbl_Pswd2.TabIndex = 8;
            this.Lbl_Pswd2.Text = "Passwort:";
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Location = new System.Drawing.Point(53, 153);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(152, 27);
            this.Lbl_Username.TabIndex = 4;
            this.Lbl_Username.Text = "Benutzername:";
            // 
            // Tb_Firstname
            // 
            this.Tb_Firstname.Location = new System.Drawing.Point(249, 42);
            this.Tb_Firstname.Name = "Tb_Firstname";
            this.Tb_Firstname.Size = new System.Drawing.Size(246, 32);
            this.Tb_Firstname.TabIndex = 1;
            // 
            // Tb_Lastname
            // 
            this.Tb_Lastname.Location = new System.Drawing.Point(249, 95);
            this.Tb_Lastname.Name = "Tb_Lastname";
            this.Tb_Lastname.Size = new System.Drawing.Size(246, 32);
            this.Tb_Lastname.TabIndex = 3;
            // 
            // Tb_Username
            // 
            this.Tb_Username.Location = new System.Drawing.Point(249, 150);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.Size = new System.Drawing.Size(246, 32);
            this.Tb_Username.TabIndex = 5;
            // 
            // Tb_Pswd1
            // 
            this.Tb_Pswd1.Location = new System.Drawing.Point(249, 205);
            this.Tb_Pswd1.Name = "Tb_Pswd1";
            this.Tb_Pswd1.PasswordChar = '*';
            this.Tb_Pswd1.Size = new System.Drawing.Size(246, 32);
            this.Tb_Pswd1.TabIndex = 7;
            // 
            // Tb_Pswd2
            // 
            this.Tb_Pswd2.Location = new System.Drawing.Point(249, 256);
            this.Tb_Pswd2.Name = "Tb_Pswd2";
            this.Tb_Pswd2.PasswordChar = '*';
            this.Tb_Pswd2.Size = new System.Drawing.Size(246, 32);
            this.Tb_Pswd2.TabIndex = 9;
            // 
            // Bt_Exit
            // 
            this.Bt_Exit.Location = new System.Drawing.Point(202, 336);
            this.Bt_Exit.Name = "Bt_Exit";
            this.Bt_Exit.Size = new System.Drawing.Size(138, 44);
            this.Bt_Exit.TabIndex = 10;
            this.Bt_Exit.Text = "Schliessen";
            this.Bt_Exit.UseVisualStyleBackColor = true;
            this.Bt_Exit.Click += new System.EventHandler(this.Bt_Exit_Click);
            // 
            // Bt_Register
            // 
            this.Bt_Register.Location = new System.Drawing.Point(357, 336);
            this.Bt_Register.Name = "Bt_Register";
            this.Bt_Register.Size = new System.Drawing.Size(138, 44);
            this.Bt_Register.TabIndex = 11;
            this.Bt_Register.Text = "Registrieren";
            this.Bt_Register.UseVisualStyleBackColor = true;
            this.Bt_Register.Click += new System.EventHandler(this.Bt_Register_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 412);
            this.Controls.Add(this.Bt_Register);
            this.Controls.Add(this.Bt_Exit);
            this.Controls.Add(this.Tb_Pswd2);
            this.Controls.Add(this.Tb_Pswd1);
            this.Controls.Add(this.Tb_Username);
            this.Controls.Add(this.Tb_Lastname);
            this.Controls.Add(this.Tb_Firstname);
            this.Controls.Add(this.Lbl_Username);
            this.Controls.Add(this.Lbl_Pswd2);
            this.Controls.Add(this.Lbl_Pswd1);
            this.Controls.Add(this.Lbl_Lastname);
            this.Controls.Add(this.Lbl_Firstname);
            this.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrierung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Firstname;
        private System.Windows.Forms.Label Lbl_Lastname;
        private System.Windows.Forms.Label Lbl_Pswd1;
        private System.Windows.Forms.Label Lbl_Pswd2;
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.Button Bt_Exit;
        private System.Windows.Forms.Button Bt_Register;
        public System.Windows.Forms.TextBox Tb_Firstname;
        public System.Windows.Forms.TextBox Tb_Lastname;
        public System.Windows.Forms.TextBox Tb_Username;
        public System.Windows.Forms.TextBox Tb_Pswd1;
        public System.Windows.Forms.TextBox Tb_Pswd2;
    }
}