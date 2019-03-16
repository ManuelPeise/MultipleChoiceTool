using MultipleChoiceTool.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceTool
{
    public partial class Register : Form
    {
        private string error = "Passwörter stimmen nicht überein!";

        public Register()
        {
            InitializeComponent();
        }

        private void Bt_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Bt_Register_Click(object sender, EventArgs e)
        { 

            var password = CheckPassword();

            if (!password.Equals(string.Empty))
            {
                RegisterUser registerUser = new RegisterUser();

                registerUser.RegisterNewUser(this, Tb_Lastname.Text, Tb_Firstname.Text, Tb_Username.Text, password);
                this.Dispose();
            }
        }

        private string CheckPassword()
        {
            try
            {
                var pswd = string.Empty;

                if (Tb_Pswd1.Text.Equals(Tb_Pswd2.Text))
                {
                    pswd = Tb_Pswd1.Text;
                }
                else
                {
                    Tb_Pswd1.BackColor = Color.Red;
                    Tb_Pswd2.BackColor = Color.Red;

                    return string.Empty;
                }

                return pswd;

            }catch(Exception ex)
            {
                MessageBox.Show(error + Environment.NewLine + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
