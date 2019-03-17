using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Models
{
    [Serializable]
    public class Configuration
    {
        [XmlElement]
        public MetaData Metadata { get; set; } = new MetaData();
        [XmlElement]
        public string Background { get; set; }
        [XmlElement]
        public string Language { get; set; }
        [XmlElement]
        public string Topic { get; set; }
        [XmlElement]
        public FolderConfiguration Folder { get; set; } = new FolderConfiguration();
    }
}
