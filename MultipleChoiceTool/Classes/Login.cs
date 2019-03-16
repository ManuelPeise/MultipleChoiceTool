using MultipleChoiceTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MultipleChoiceTool.Classes
{
    public class Login
    {
        public string User { get; set; }

        

        private bool UserLogin(string username, string password)
        {
            RegisterUser register = new RegisterUser();

            var user = GetUser(username);

            if(user.Firstname.Equals(username) && user.Password.Equals(register.encodePassword(password)))
            {
                return true;
            }

            return false;
        }

        private User GetUser(string username)
        {
            var path = Properties.Settings.Default.UserXml;
            var document = XDocument.Load(path);

            var user = (from x in document.Descendants("User")
                       .Where(name => name.Attribute("lastname").Value
                       .Equals(username))
                        select new User
                        {
                            Id = Convert.ToInt32(x.Attribute("id").Value),
                            Lastname = x.Attribute("lastname").Value,
                            Firstname = x.Attribute("firstname").Value,
                            Password = x.Attribute("password").Value

                        }).First();

            return user;
        }

        private string decodePassword(string password)
        {
            var pswd = string.Empty;
            var newChars = new List<char>();
            var key_1 = Properties.Settings.Default.Key_1;
            var key_2 = Properties.Settings.Default.Key_2;
            var key_3 = Properties.Settings.Default.Key_3;
            var chars = password.ToCharArray();

            foreach (var c in chars)
            {
                var i = Convert.ToInt32(c);
                var x = i * key_1 + key_2;
                newChars.Add(Convert.ToChar(x));
            }

            pswd = new string(newChars.ToArray());

            return pswd;
        }
    }
}
