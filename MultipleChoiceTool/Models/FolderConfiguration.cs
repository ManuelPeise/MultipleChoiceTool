using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Models
{
    [Serializable]
    public class FolderConfiguration
    {
        [XmlAttribute]
        public string ConfigurationFolder { get; set; }
        [XmlAttribute]
        public string NewTestFolder { get; set; }
        [XmlAttribute]
        public string TestFolder { get; set; }
        [XmlAttribute]
        public string UserFolder { get; set; }
    }
}
