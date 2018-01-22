using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using DTO;

namespace DAO
{
    public class DAO_User
    {
        private static string userXmlFilePath = Path.Combine(Environment.CurrentDirectory, "User.xml");

        private static void CreateXML()
        {
            if (File.Exists(userXmlFilePath))
            {
                return;
            }
            else
            {
                XmlTextWriter xtw = new XmlTextWriter(userXmlFilePath, Encoding.UTF8);
                xtw.WriteStartDocument();
                xtw.WriteStartElement("UserDetails");
                xtw.WriteEndElement();
                xtw.Close();
            }
        }

        public static void InsertUser(DTO_User user)
        {
            CreateXML();
            XmlDocument xd = new XmlDocument();
            FileStream lfile = new FileStream(userXmlFilePath, FileMode.Open);
            xd.Load(lfile);

            XmlElement userNode = xd.CreateElement("User");
            userNode.SetAttribute("Username", user.Username);
            XmlElement passwordNode = xd.CreateElement("Password");
            XmlText pwText = xd.CreateTextNode(user.Password);
            XmlElement emailNode = xd.CreateElement("Email");
            XmlText eText = xd.CreateTextNode(user.Email);

            passwordNode.AppendChild(pwText);
            emailNode.AppendChild(eText);

            userNode.AppendChild(passwordNode);
            userNode.AppendChild(emailNode);

            xd.DocumentElement.AppendChild(userNode);

            lfile.Close();
            xd.Save(userXmlFilePath);
        }

        public static DTO_User SearchUser(string userName)
        {
            CreateXML();
            XmlDocument xd = new XmlDocument();
            FileStream rfile = new FileStream(userXmlFilePath, FileMode.Open);
            xd.Load(rfile);

            DTO_User user = new DTO_User();
            XmlNodeList list = xd.GetElementsByTagName("User");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement userNode = (XmlElement)xd.GetElementsByTagName("User")[i];
                XmlElement passwordNode = (XmlElement)xd.GetElementsByTagName("Password")[i];
                XmlElement emailNode = (XmlElement)xd.GetElementsByTagName("Email")[i];

                if (userNode.GetAttribute("Username") == userName)
                {
                    user.Username = userName;
                    user.Password = passwordNode.InnerText;
                    user.Email = emailNode.InnerText;
                    rfile.Close();
                    return user;
                }
            }

            rfile.Close();
            return null;
        }
    }
}
