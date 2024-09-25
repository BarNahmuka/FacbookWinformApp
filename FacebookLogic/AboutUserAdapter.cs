using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    class AboutUserAdapter: iAbout
    {
        private readonly User r_User;

        public AboutUserAdapter(User i_user)
        {
            r_User = i_user;
        }

        public List<string> AboutUser()
        {
           List<string> userDetails = new List<string>();

            foreach (PropertyInfo property in typeof(User).GetProperties())
            {
                if (property.PropertyType == typeof(string) && !property.Name.Contains("URL") && property.GetValue(r_User) != null)
                {
                    userDetails.Add(property.Name + ": " + property.GetValue(r_User));
                }
            }

            return userDetails;
        }
    }
}
