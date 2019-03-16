using MultipleChoiceTool.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MultipleChoiceTool.Classes
{
    public class RegisterUser
    {
        private List<User> Users { get; set; } = new List<User>();
        private string Path { get; set; } = "Config\\Appuser.xml";
        
        private void RegisterNewUser(string lastname, string firstname, string password)
        {
            Users.Clear();
            Users = GetUser();
            var securedPassword = encodePassword(password);

            var user = new User
            {
                Id = Users.Count() + 1,
                Lastname = lastname,
                Firstname = firstname,
                Password = securedPassword
            };

            Users.Add(user);
        }

        public string encodePassword(string password)
        {
            var pswd = string.Empty;
            var newChars = new List<char>();
            var key_1 = Properties.Settings.Default.Key_1;
            var key_2 = Properties.Settings.Default.Key_2;
            var key_3 = Properties.Settings.Default.Key_3;
            var chars = password.ToCharArray();

            foreach(var c in chars)
            {
                var i = Convert.ToInt32(c);
                var x = i / key_1 - key_2;
                newChars.Add(Convert.ToChar(x));
            }

            pswd = new string(newChars.ToArray());

            return pswd; 
        }

        private List<User> GetUser()
        {
            var path = Properties.Settings.Default.UserXml;
            var users = new List<User>();
            if (File.Exists(Path))
            {
                var document = XDocument.Load(Path);

                users = (from x in document.Descendants("User")
                             select new User
                             {
                                 Id = Convert.ToInt32(x.Attribute("Id").Value),
                                 Lastname = x.Attribute("Lastname").Value,
                                 Firstname = x.Attribute("Firstname").Value,
                                 Username = x.Attribute("Username").Value,
                                 Password = x.Attribute("Password").Value

                             }).ToList();
            }
            
           return users;
        }

        public void RegisterNewUser(Register reg, string name, string firstname, string username, string pswd)
        {
            Users.Clear();
            Users = GetUser();

            var password = encodePassword(pswd);

            var user = new User
            {
                Id = Users.Count + 1,
                Lastname = name,
                Firstname = firstname,
                Username = username,
                Password = password
            };
            var usernames = Users.Select(x => x.Username).ToList();

            if (!usernames.Contains(user.Username))
            {
                Users.Add(user);
            }
            else
            {
                MessageBox.Show($"Der Benutzername {user.Username} ist nicht verfügbar!");
                reg.Tb_Username.BackColor = Color.Red;
            }

            SerializeUser(Users);
        }

        private void SerializeUser(List<User> users)
        {
            using (var stream = new FileStream(Path, FileMode.Create, FileAccess.Write))
            {
                var serializer = new XmlSerializer(typeof(List<User>));
                serializer.Serialize(stream, users);
            }
        }
    }
}
