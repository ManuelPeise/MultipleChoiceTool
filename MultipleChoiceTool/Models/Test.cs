using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Models
{
    [Serializable]
    public class Test
    {
        [XmlElement]
        public MetaData MetaData { get; set; }
        [XmlElement("Question")]
        public List<Question> Questions { get; set; }
    }
}
