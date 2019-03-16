using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Models
{
    [Serializable]
    public class User
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlAttribute]
        public string Lastname { get; set; }
        [XmlAttribute]
        public string Firstname { get; set; }
        [XmlAttribute]
        public string Username { get; set; }
        [XmlAttribute]
        public string Password { get; set; }
    }
}
