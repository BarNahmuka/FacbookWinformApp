using FacebookLogic;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private LoginResult m_LoginResult;
        public FormMain m_FormMain;
        private FacebookLogic.UserIdentification m_User;

        public FormLogin()
        {
            InitializeComponent();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");
            String token = UserIdentification.LoadFromFile();

            if (checkBoxRemember.Checked == true)
            {
                if (token != null)
                {
                    m_LoginResult = FacebookService.Connect(token);
                    m_FormMain = new FormMain(m_LoginResult.LoggedInUser);
                    Close();
                    m_FormMain.FetchData();
                }
                else
                {
                    login();
                    m_User.SaveToFile();
                }
            }
            else
            {
                login();
                m_User.EraseTokenFile();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
               "909111124299634",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_User = new UserIdentification(m_LoginResult.AccessToken);
                m_FormMain = new FormMain(m_LoginResult.LoggedInUser);
                Close();
                m_FormMain.FetchData();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
