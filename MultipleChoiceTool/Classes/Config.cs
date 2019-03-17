using MultipleChoiceTool.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Classes
{
    public class Config
    {
        public Configuration _Config { get; set; } = new Configuration();
        private FolderBrowserDialog Dialog { get; set; } = new FolderBrowserDialog();
        private string ConfigPath { get; set; }

        public Config()
        {
            this.ConfigPath = Properties.Settings.Default.Config != null ? Properties.Settings.Default.Config : string.Empty;
            LoadConfig(ConfigPath);
        }

        public Configuration LoadConfig(string folder)
        {
            var files = new List<string>();

            if (folder != string.Empty)
            {
                try
                {
                    files = Directory.GetFiles(folder).ToList();

                } catch (Exception ex)
                {
                    this.Dialog = new FolderBrowserDialog();
                    DialogResult result = Dialog.ShowDialog();
                    Properties.Settings.Default.Config = Dialog.SelectedPath;
                    Properties.Settings.Default.Save();
                }

            }
            else
            {
                this.Dialog = new FolderBrowserDialog();
                DialogResult result = Dialog.ShowDialog();
                Properties.Settings.Default.Config = Dialog.SelectedPath;
                Properties.Settings.Default.Save();
            }


            if (files.Count() == 0)
            {
                var fileName = "Configfile.xml";
                SetConfiguration(fileName);

            }

            try
            {
                var configFolder = Properties.Settings.Default.Config;
                var file = Directory.GetFiles(configFolder, "Configfile.xml").First();

                if (file != null)
                {

                    var config = XDocument.Load(file);
                    _Config.Folder = new FolderConfiguration();

                    _Config.Folder = (from x in config.Descendants("Folder")
                                      select new FolderConfiguration
                                      {
                                          ConfigurationFolder = x.Attribute("ConfigurationFolder").Value != null ? x.Attribute("ConfigurationFolder").Value : string.Empty,
                                          NewTestFolder = x.Attribute("TestFolder").Value != null ? x.Attribute("TestFolder").Value : string.Empty,
                                          TestFolder = x.Attribute("TestFolder").Value != null ? x.Attribute("TestFolder").Value : string.Empty,
                                          UserFolder = x.Attribute("UserFolder").Value != null ? x.Attribute("UserFolder").Value : string.Empty

                                      }).First();

                    _Config.Background = (from x in config.Descendants("Background") select x.Value).First();

                    _Config.Language = (from x in config.Descendants("Language") select x.Value).First();

                    _Config.Metadata = GetConfigMetaData();
                  

                }

                return _Config;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Configurationfile not exists, " + Environment.NewLine + ex.Message);

                this.Dialog = new FolderBrowserDialog();
                DialogResult result = Dialog.ShowDialog();
                var fileName = "Configfile.xml";
                SetConfiguration(fileName);
                _Config = LoadConfig(_Config.Folder.ConfigurationFolder);

                return _Config;
            }
            }
        
        private void SetConfiguration(string fileName)
        {
            var config = new Configuration
            {
                Metadata = GetConfigMetaData(),
                Folder = SetFolderConfig(),
                Background = Color.LightGray.ToString(),
                Language = "German",
                Topic = string.Empty

            };

            Properties.Settings.Default.Config = Dialog.SelectedPath;
            Properties.Settings.Default.Save();
            SaveConfig(config, _Config.Folder.ConfigurationFolder, fileName);

        }

        public MetaData GetConfigMetaData()
        {
            return new MetaData
            {
                Description = "Configuration",
                Creationdate = DateTime.Now.ToShortDateString(),
                System = "Multiple Choice Tool",
                Version = "1.0"
            };

        }

        private FolderConfiguration SetFolderConfig()
        {
            _Config.Folder.ConfigurationFolder = Dialog.SelectedPath;
            _Config.Folder.NewTestFolder = string.Empty;
            _Config.Folder.TestFolder = string.Empty;
            _Config.Folder.UserFolder = string.Empty;

            return _Config.Folder;
        }

        public void SaveConfig(Configuration config, string path, string filename)
        {
            path = Path.Combine(path, filename);

            using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                var serializer = new XmlSerializer(typeof(Configuration));

                serializer.Serialize(stream, config);
            }
        }

        public Color SetColor(string background)
        {
            var p = background.Split(new char[] { ',', ']' });

            int a = Convert.ToInt32(p[0].Substring(p[0].IndexOf('=') + 1));
            int r = Convert.ToInt32(p[1].Substring(p[1].IndexOf('=') + 1));
            int g = Convert.ToInt32(p[2].Substring(p[2].IndexOf('=') + 1));
            int b = Convert.ToInt32(p[3].Substring(p[3].IndexOf('=') + 1));

            var color = Color.FromArgb(a, r, g, b);

            return color;

        }


    }
}
