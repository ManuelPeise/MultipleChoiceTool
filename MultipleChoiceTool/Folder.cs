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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MultipleChoiceTool
{
    public partial class Folder : Form
    {
        private FolderBrowserDialog Dialog { get; set; } = new FolderBrowserDialog();
        private ColorDialog Color { get; set; } = new ColorDialog();
        private FolderConfiguration FolderConfig { get; set; } = new FolderConfiguration();
        private Configuration Conf { get; set; } = new Configuration();
        private Config Config { get; set; } = new Config();
        private List<string> Errors { get; set; } = new List<string>();


        public Folder(Configuration config)
        {
            InitializeComponent();
            this.Conf = Config._Config;

            SetValues();


        }

        private void SetValues()
        {
            TB_ConfigFolder.Text = Conf.Folder.ConfigurationFolder;
            TB_TestImportFolder.Text = Conf.Folder.NewTestFolder;
            Tb_TestFolder.Text = Conf.Folder.TestFolder;
            Tb_UserFolder.Text = Conf.Folder.UserFolder;

            if(Conf.Language.Equals("Deutsch"))
            {
                Rb_German.Checked = true;
            }
            else
            {
                Rb_English.Checked = true;
            }

            var colorFromConfig = Conf.Background;
            var color = new Color();
            
            
            
          
        }

        public bool CheckConfiguration()
        {

            if (File.Exists(TB_ConfigFolder.Text))
            {

            }
            else
            {
                Errors.Add("Configfolder is not set!");
            }

            if (File.Exists(Tb_UserFolder.Text))
            {
                
            }
            else
            {
                Errors.Add("Userfolder is not set!");
            }
            
            if(File.Exists(TB_TestImportFolder.Text))
            {

            }
            else
            {
                Errors.Add("Importfolder is not set!");
            }

            if(File.Exists(Tb_TestFolder.Text))
            {

            }
            else
            {
                Errors.Add("Testfolder is not set!");
            }

            return true;
        }
        
        private void Btn_ChooseUserFolder_Click(object sender, EventArgs e)
        {
            this.Dialog = FolderChooser;
            DialogResult result = Dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                FolderConfig.UserFolder = Dialog.SelectedPath;
                Tb_UserFolder.Text = FolderConfig.UserFolder;

            }
        }

        private void Btn_ChooseImportFolder_Click(object sender, EventArgs e)
        {
            this.Dialog = FolderChooser;
            DialogResult result = Dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                FolderConfig.NewTestFolder = Dialog.SelectedPath;
                TB_TestImportFolder.Text = FolderConfig.NewTestFolder;

            }
        }

        private void Btn_ChooseTestFolder_Click(object sender, EventArgs e)
        {
            this.Dialog = FolderChooser;
            DialogResult result = Dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                FolderConfig.TestFolder = Dialog.SelectedPath;
                Tb_TestFolder.Text = FolderConfig.TestFolder;

            }
        }

        private void Btn_ChooseConfigFolder_Click(object sender, EventArgs e)
        {
            this.Dialog = FolderChooser;
            DialogResult result = Dialog.ShowDialog();
            var fileName = "Configfile.xml";

            if (result == DialogResult.OK)
            {
                FolderConfig.ConfigurationFolder = Dialog.SelectedPath;
                TB_ConfigFolder.Text = FolderConfig.ConfigurationFolder;
            }

            Properties.Settings.Default.Config = TB_ConfigFolder.Text;
            Properties.Settings.Default.Save();
        }

        private void Rb_German_CheckedChanged(object sender, EventArgs e)
        {
            if(Rb_German.Checked == true)
            {
                Rb_English.Checked = false;
                Conf.Language = Rb_German.Text;
            }
        }

        private void Rb_Enlish_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_English.Checked == true)
            {
                Rb_German.Checked = false;
                Conf.Language = Rb_English.Text;
            }
        }

        private void Btn_ChooseColor_Click(object sender, EventArgs e)
        {
            var result = Color.ShowDialog();

            if(result == DialogResult.OK)
            {
                Conf.Background = Color.Color.ToString();
            }
        }

        private void Btn_SaveConfig_Click(object sender, EventArgs e)
        {
            FolderConfig.ConfigurationFolder = TB_ConfigFolder.Text;
            FolderConfig.NewTestFolder = TB_TestImportFolder.Text;
            FolderConfig.TestFolder = Tb_TestFolder.Text;
            FolderConfig.UserFolder = Tb_UserFolder.Text;

            var filename = "ConfigFile.xml";
            Conf.Metadata = Config.GetConfigMetaData();
            Conf.Folder = FolderConfig;
            Config.SaveConfig(Conf, FolderConfig.ConfigurationFolder, filename);
            this.Close();

        }
    }
}
