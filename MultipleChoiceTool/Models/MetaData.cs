using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Models
{
    [Serializable]
    public class MetaData
    {
        [XmlAttribute]
        public string Description { get; set; }
        [XmlAttribute]
        public string Creationdate { get; set; }
        [XmlAttribute]
        public string System { get; set; }
        [XmlAttribute]
        public string Version { get; set; }

    }
}
