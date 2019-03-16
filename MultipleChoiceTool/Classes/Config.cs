using MultipleChoiceTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTool.Classes
{
    public class Config
    {
        public Configuration _Config { get; set; }

        public Config()
        {

        }

        private void SetConfiguration()
        {

        }

        public Configuration GetConfiguration()
        {
            var config = new Configuration();

            return config;
        }


    }
}
