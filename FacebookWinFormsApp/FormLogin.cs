using FacebookLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
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
        private FacebookFacade m_FacebookFacade = new FacebookFacade();

        public FormLogin()
        {
            InitializeComponent();
            CheckIfUserRemembered();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
            m_FacebookFacade.RememberUserStatus(checkBoxRemember.Checked, m_LoginResult.AccessToken);
            Close();
        }
        private void CheckIfUserRemembered()
        {
            String token = m_FacebookFacade.GetSaveUser();

            if (token != null)
            {
                m_LoginResult = FacebookService.Connect(token);
                checkBoxRemember.Checked = true;
            }
        }

        private void login()
        {
            if (m_LoginResult == null)
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
            }
            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_FormMain = new FormMain(m_LoginResult.LoggedInUser, m_FacebookFacade);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
