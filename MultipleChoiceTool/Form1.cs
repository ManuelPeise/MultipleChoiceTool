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

        public Form1()
        {
            InitializeComponent();
        }

        private void Btm_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Username = Tb_UserName.Text;
            var password = Tb_Password.Text;

            var main = new Main();
            main.ShowDialog();
        }

        private void Br_Register_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.ShowDialog();
        }
    }
}
