﻿using System;
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
        public MetaData Metadata { get; set; }
        [XmlAttribute]
        public Color Background { get; set; }
        [XmlAttribute]
        public string Language { get; set; }
    }
}
