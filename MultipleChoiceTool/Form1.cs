using MultipleChoiceTool.Classes;
using MultipleChoiceTool.Models;
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
    public partial class Form1 : Form
    {
        private string Username { get; set; }
        private Configuration Configuration { get; set; }

        public Form1()
        {
            InitializeComponent();
            var config = new Config();
            Configuration = config.LoadConfig(Properties.Settings.Default.Config);
            
            if (Configuration == null)
            {
                var folder = new Folder(Configuration);
                folder.ShowDialog();
            }

            this.BackColor = config.SetColor(Configuration.Background);

        }
        
        private void Btm_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            var username = Tb_UserName.Text;
            var password = Tb_Password.Text;

            var user = new RegisterUser();
            var currentUser = user.GetCurrentUser(username);
            var pswd = user.encodePassword(password);

            if (currentUser.Username.Equals(username) && currentUser.Password.Equals(pswd))
            {
                var main = new Main(username, Configuration);
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Benutzername oder Password falsch!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        
        private void Br_Register_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.ShowDialog();
        }
    }
}
