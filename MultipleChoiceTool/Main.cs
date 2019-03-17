using MultipleChoiceTool.Classes;
using MultipleChoiceTool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceTool
{
    public partial class Main : Form
    {
        private Configuration Config { get; set; }
        private Config AppConfig { get; set; } = new Config();
        private string User { get; set; }
        private int CountOfQuestions { get; set; }
        private List<Question> Questions { get; set; } = new List<Question>();

        public Main(string username, Configuration config)
        {
            this.Config = config;
            this.User = username;
            InitializeComponent();
            FillBbCountOfQuestions();
            FillBbTheme();

            this.BackColor = AppConfig.SetColor(Config.Background);

        }


        private void FillBbCountOfQuestions()
        {
            var counts = new int[] { 10, 20, 30, 40, 50};

            CB_QuestionCount.Items.Clear();

            foreach (var count in counts)
            {
                
                CB_QuestionCount.Items.Add(count);
            }
        }

        private void FillBbTheme()
        {
            var testLoader = new TestConverter();
            var topics = testLoader.GetFiles();

            CB_Topic.Items.Clear();

            foreach(var topic in topics)
            {
                var file = new FileInfo(topic);
                var split = file.Name.Split('.');
                CB_Topic.Items.Add(split[0]);
            }
            //[MP] TODO implement
        }

        #region Config
        #region Colors
        private void rotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            Config.Background = this.BackColor.ToString();
        }

        private void ColorStandard_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            Config.Background = this.BackColor.ToString();
        }

        private void blauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            Config.Background = this.BackColor.ToString();
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

       private string GetFilePath(string folder, string file)
       {
            return Path.Combine(folder, file);
       }

        
        
        #endregion

        private void AddTest_Click(object sender, EventArgs e)
        {
            var t = new TestConverter();
            t.ConvertTests();
        }

        private void Item_StartTest_Click(object sender, EventArgs e)
        {
            StartTest(Config);
        }

        private void StartTest(Configuration config)
        {
           
        }

        private void ordnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var folder = new Folder(Config);
            folder.ShowDialog();
        }

        private void CB_Topic_SelectedIndexChanged(object sender, EventArgs e)
        {
            var file = CB_Topic.Text + ".xml";
            var filePath = GetFilePath(Config.Folder.TestFolder, file);

            var testLoader = new TestLoader(CountOfQuestions, Config);
        }

        private void CB_QuestionCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(CB_QuestionCount.Text, out var count);
            CountOfQuestions = count;
        }
    }
}
