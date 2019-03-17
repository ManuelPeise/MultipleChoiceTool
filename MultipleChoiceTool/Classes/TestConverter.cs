using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MultipleChoiceTool.Models;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Classes
{
    public class TestConverter
    {
        private string SourcePath = "D:\\Github\\MultipleChoiceTool\\MultipleChoiceTool\\Files\\NewTests\\";
        private string TargetPath = "D:\\Github\\MultipleChoiceTool\\MultipleChoiceTool\\Files\\Tests\\";

        public TestConverter()
        {
            
        }

        public List<string> GetFiles()
        {
            return Directory.GetFiles(TargetPath, "*xml").ToList();
        }

        public List<string> GetNewFiles()
        {
            return Directory.GetFiles(SourcePath, "*txt").ToList();
        }

        public List<Test> GetNewTests()
        {
            var test = new Test();
            var tests = new List<Test>();
            var questions = new List<Question>();
            var files = GetNewFiles();

            foreach (var file in files)
            {
                var t = file.Split('.');
                var topic = t[0].Split('\\');

                var answers = new List<Answer>();
                
                using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                using (var reader = new StreamReader(stream))
                {
                    while(reader.Peek() > -1)
                    {
                        answers.Clear();

                        var question = reader.ReadLine();
                        answers.Add(ReadAnswer(reader));
                        answers.Add(ReadAnswer(reader));
                        answers.Add(ReadAnswer(reader));
                        answers.Add(ReadAnswer(reader));

                        questions.Add(new Question
                        {
                            _Question = question,
                            Aswers = answers
                        });
                        
                    }
                }
                
                
                test.MetaData = GetMetaData(topic[topic.Count()-1]);
                test.Questions = questions;

                tests.Add(test);
            }
            return tests;
        }

        public void SerializeTest(Test test)
        {
            var fileName = test.MetaData.Topic + ".xml";
            var path = Path.Combine(TargetPath, fileName);

            using(var stream = new FileStream(path, FileMode.Create, FileAccess.Write))    
            {
                var serializer = new XmlSerializer(typeof(Test));
                serializer.Serialize(stream, test);
            }
        }

        public void ConvertTests()
        {
            var tests = GetNewTests();

            foreach (var test in tests)
            {
                SerializeTest(test);
            }
        }

        private Answer ReadAnswer(StreamReader reader)
        {
            var answ = new Answer();

            try
            {
                var answer = reader.ReadLine();
                var split = answer.Split(' ');

                var correct = Convert.ToChar(split[1]) == 't' ? true : false;
                
                answ._Answer = split[0];
                answ.Correct = correct;
                
            }
            catch(Exception ex)
            {
                //[MP] TODO ExceptionHandling
            }

            return answ;
        }

        private MetaData GetMetaData(string topic)
        {
            return new MetaData
            {
                Topic = topic,
                Creationdate = DateTime.Now.ToShortDateString(),
                System = "Multiple Choice Tests",
                Version = "1.0"
            };
        }
    }
}
