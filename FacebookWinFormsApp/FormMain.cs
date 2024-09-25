using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using FacebookLogic;
using System.Text;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly FacebookFacade r_FacadeFacebook;
        private User m_LoggedInUser;
        private bool m_IsFriendProfileflag = false;

        public FormMain(User i_User, FacebookFacade i_FacebookFacade)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_LoggedInUser = i_User;
            r_FacadeFacebook = i_FacebookFacade;
            r_FacadeFacebook.CheckIfSongAvailable(m_LoggedInUser.Name);
            r_FacadeFacebook.InitializeSoundManager(m_LoggedInUser.Name);
        }

        public FormMain(User user, bool isFriendProfileflag, FacebookFacade i_FacebookFacade)
        {
            InitializeComponent();
            m_IsFriendProfileflag = isFriendProfileflag;
            if (isFriendProfileflag)
            {
                buttonUploadNewSong.Visible = false;
                buttonGoToFriendProfile.Visible = false;
                buttonLogout.Text = "Exit profile";
            }

            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_LoggedInUser = user;
            r_FacadeFacebook = i_FacebookFacade;
            r_FacadeFacebook.SwitchSoundManagerUser(m_LoggedInUser.Name);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            r_FacadeFacebook.StopSong();
            if (m_IsFriendProfileflag)
            {
                r_FacadeFacebook.RevertSoundManagerUser();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (m_IsFriendProfileflag)
            {
                Close();
            }
            else
            {
                FacebookService.LogoutWithUI();
                buttonLogout.Enabled = false;
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selectedPosts = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            FacebookFacade.DisplayCover(selectedPosts.PictureURL, listBoxPosts, pictureBox);

            try
            {
                foreach (Comment comment in selectedPosts.Comments)
                {
                    if (comment != null)
                    {
                        listBoxComments.Invoke(new Action(() => listBoxComments.Items.Add(comment)));
                    }
                }
            }
            catch
            {
                if (listBoxComments.Items.Count == 0)
                {
                    listBoxComments.Invoke(new Action(() => listBoxComments.Items.Add("No comments to retrieve...")));
                }
            } 
        }

        private void buttonAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                FormAlbums albumsForm = new FormAlbums(m_LoggedInUser);
                albumsForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Albums aren't accessible at the moment.");
            }
        }

        private void buttonLikedGroups_Click(object sender, EventArgs e)
        {
            CollectionFormFactory.CreateForm(m_LoggedInUser, eCollectionFormType.LikedPagesForm).ShowDialog();
        }

        private void fetchFriends()
        {
            FacebookObjectCollection<User> users = m_LoggedInUser.Friends;

            foreach (User friends in users)
            {
                if (friends.Name != null)
                {
                    listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friends.Name)));
                }
            }

            if (listBoxFriends.Items.Count == 0)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("You don't liked to any page")));
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedIndex != -1)
            {
                User selectedFriends = m_LoggedInUser.Friends[listBoxFriends.SelectedIndex];
                FacebookFacade.DisplayCover(selectedFriends.PictureLargeURL, listBoxFriends, pictureBox);
            }
        }

        private void fetchAboutMe()
        {
            foreach(String detailsField in r_FacadeFacebook.GetUserDetails(m_LoggedInUser))
            {
                listBoxAbout.Invoke(new Action(() => listBoxAbout.Items.Add(detailsField)));
            }
        }

        public void FetchData()
        {
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            Thread.Sleep(1000);
            new Thread(() => fetchPosts()).Start();
            new Thread(() => fetchFriends()).Start();
            new Thread(() => fetchAboutMe()).Start();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            CollectionFormFactory.CreateForm(m_LoggedInUser, eCollectionFormType.EventsForm).ShowDialog();
        }
        

        private void goToProfile_Click(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedIndex != -1)
            {
                r_FacadeFacebook.StopSong();
                User friend = m_LoggedInUser.Friends[listBoxFriends.SelectedIndex];
                FormMain friend_form = new FormMain(friend,true, r_FacadeFacebook);
                friend_form.ShowDialog();
            }
        }

        public void ButtonPlayClick(object sender, EventArgs e)
        {
            try
            {
                r_FacadeFacebook.PlaySong();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Sound file not found.");
            }
        }

        private void buttonStopClick(object sender, EventArgs e)
        {
            r_FacadeFacebook.StopSong();
        }

        private void uploadNewSongClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.wav";
                openFileDialog.Title = "Select a Sound File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    r_FacadeFacebook.UploadSong(selectedFilePath);
                    MessageBox.Show("Sound file uploaded successfully.");
                }
            }
        }

        private void buttonAdvancedSearch_Click(object sender, EventArgs e)
        {
            FormAdvancedSearch advancedSearch = new FormAdvancedSearch(m_LoggedInUser, r_FacadeFacebook);
            advancedSearch.ShowDialog();
            
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            CollectionFormFactory.CreateForm(m_LoggedInUser, eCollectionFormType.GroupsForm).ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FetchData();
        }
    }
}
