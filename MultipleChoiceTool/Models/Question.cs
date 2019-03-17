using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Models
{
    [Serializable]
    public class Question
    {
        [XmlAttribute]
        public string _Question { get; set; }
        [XmlElement("Answers")]
        public List<Answer> Aswers { get; set; }

    }
}
