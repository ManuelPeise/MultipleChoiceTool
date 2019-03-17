using MultipleChoiceTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTool.Classes
{
    public class TestLoader
    {
        private int CountOfQuestions { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        private Configuration Config { get; set; }

        public TestLoader(int count, Configuration config)
        {
            Config = config;
            CountOfQuestions = count;
            Questions = GetQuestions(CountOfQuestions);
        }

        private List<Question> GetQuestions(int count)
        {
            var questions = new List<Question>();

            return questions;
        }
    }
}
