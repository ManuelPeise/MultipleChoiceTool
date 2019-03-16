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
    public partial class Main : Form
    {
        private Configuration Config { get; set; }
        private string User { get; set; }

        public Main(string username)
        {
            this.User = username;
            InitializeComponent();
            FillBbCountOfQuestions();
            this.Config = new Configuration();
            //load Config from file
        }


        private void FillBbCountOfQuestions()
        {
            var counts = new int[] { 10, 20, 30, 40, 50};

            Cb_CountOfQuestions.Items.Clear();

            foreach (var count in counts)
            {
                
                Cb_CountOfQuestions.Items.Add(count);
            }
        }

        private void FillBbTheme()
        {
            //[MP] TODO implement
        }

        #region Config
        #region Colors
        private void rotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            Config = new Configuration();
            Config.Background = this.BackColor;
        }

        private void ColorStandard_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            Config = new Configuration();
            Config.Background = this.BackColor;
        }

        private void blauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            Config = new Configuration();
            Config.Background = this.BackColor;
        }
        #endregion
        #region Language
        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var language = "German";
            Config.Language = language;
            
        }

        private void englischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var language = "English";
            Config.Language = language;
        }

        #endregion
        
        private void Cb_CountOfQuestions_Click(object sender, EventArgs e)
        {

        }

        private void CB_Theme_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void Item_StartTest_Click(object sender, EventArgs e)
        {

        }
    }
}
