using System;
using System.IO;
using System.Xml.Serialization;

namespace FacebookLogic
{
    public class UserIdentification
    {
        public string m_Token;
        private static string sr_FilePath = Path.Combine(Environment.CurrentDirectory, "accessToken");

        public UserIdentification(string i_token)
        {
            m_Token = i_token;
        }
        public UserIdentification()
        {
            m_Token = null;
        }

        public static string LoadFromFile()
        {
            UserIdentification lastUser = null;

            if (File.Exists(sr_FilePath))
            {
                using (Stream stream = new FileStream(sr_FilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(UserIdentification));
                    lastUser = serializer.Deserialize(stream) as UserIdentification;

                }
            }
            return lastUser?.m_Token;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(sr_FilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static void EraseTokenFile()
        {
            if (File.Exists(sr_FilePath))
            {
                File.Delete(sr_FilePath);
            }
        }
    }
}