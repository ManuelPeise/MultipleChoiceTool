using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Models
{
    [Serializable]
    public class Answer
    {
        [XmlAttribute]
        public string _Answer { get; set; }
        [XmlAttribute]
        public bool Correct { get; set; }
    }
}
