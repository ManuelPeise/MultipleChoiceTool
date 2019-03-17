using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Models
{
    [Serializable]
    public class UserData
    {
        [XmlElement("MetaData")]
        public MetaData MetaData { get; set; }
        [XmlElement]
        public List<User> User { get; set; } = new List<User>();
    }
}
