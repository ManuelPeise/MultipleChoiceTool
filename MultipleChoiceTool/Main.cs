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

        public Main()
        {
            InitializeComponent();
            this.Config = new Configuration();
            //load Config from file
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
        #endregion
    }
}
