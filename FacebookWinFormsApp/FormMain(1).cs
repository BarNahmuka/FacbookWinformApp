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
        private SoundManager m_SoundManager;
        private User m_LoggedInUser;
        private bool m_IsFriendProfileflag = false;

        public FormMain(User user)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_LoggedInUser = user;
            m_SoundManager = new SoundManager(m_LoggedInUser.Name);

        }
        public FormMain(User user, bool isFriendProfileflag)
        {
            InitializeComponent();

            if (isFriendProfileflag == true)
            {
                m_IsFriendProfileflag = true;
                buttonUploadNewSong.Visible = false;
                buttonGoToFriendProfile.Visible = false;
                buttonLogout.Text = "Exit profile";
            }

            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_LoggedInUser = user;
            m_SoundManager = new SoundManager(m_LoggedInUser.Name);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if(m_IsFriendProfileflag)
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
            listBoxPosts.Items.Clear();

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
            UtilitiesForForm.DisplayCover(selectedPosts.PictureURL, listBoxPosts,pictureBox);

            foreach(Comment comment in selectedPosts.Comments)
            {
                if (comment != null)
                {
                    listBoxComments.Invoke(new Action(() => listBoxComments.Items.Add(comment)));
                }
            }

            if (listBoxComments.Items.Count == 0)
            {
                listBoxComments.Invoke(new Action(() => listBoxComments.Items.Add("No comments to retrieve...")));
            }
        }


        private void buttonAlbum_Click(object sender, EventArgs e)
        {
            FormAlbums albumsForm = new FormAlbums(m_LoggedInUser);
            albumsForm.ShowDialog();
        }

        protected void ListBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLikedPages.SelectedIndex != -1)
            {
                Page selectedPgage = m_LoggedInUser.LikedPages[listBoxLikedPages.SelectedIndex];
                UtilitiesForForm.DisplayCover(selectedPgage.PictureLargeURL, listBoxLikedPages,pictureBox);
            }
        }

        private void buttonLikedGroups_Click(object sender, EventArgs e)
        {
            UtilitiesForForm.FetchLikedPages(m_LoggedInUser, listBoxLikedPages);
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
                UtilitiesForForm.DisplayCover(selectedFriends.PictureLargeURL, listBoxFriends, pictureBox);
            }
        }

        private void fetchAboutMe()
        {
            if (m_LoggedInUser.Location != null)
            {
                textBoxLocation.Invoke(new Action(() => textBoxLocation.Text = "My location: " + m_LoggedInUser.Location.Name));
            }

            if (m_LoggedInUser.Birthday != null)
            {
                textBoxBirthday.Invoke(new Action(() => textBoxBirthday.Text = "My birthday: " + m_LoggedInUser.Birthday));
            }

            if (m_LoggedInUser.Email != null)
            {
              textBoxEmail.Invoke(new Action(() => textBoxEmail.Text = "Email: " + m_LoggedInUser.Email));
            }

            if (m_LoggedInUser.WorkExperiences != null)
            {
                textBoxWork.Invoke(new Action(() => textBoxWork.Text = m_LoggedInUser.WorkExperiences.ToString()));
            }
            else
            {
                textBoxWork.Invoke(new Action(() => textBoxWork.Text = "You dont have any work experience updated"));
            }

            if (m_LoggedInUser.Name != null)
            {
                textBoxName.Invoke(new Action(() => textBoxName.Text = m_LoggedInUser.Name));
            }

        }

        public void FetchData()
        {
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            Thread.Sleep(5000);
            new Thread(() => fetchPosts()).Start();
            new Thread(() => fetchFriends()).Start();
            new Thread(() => fetchAboutMe()).Start();
        }

        private void fetchGroups()
        {
            foreach (Group group in m_LoggedInUser.Groups)
            {
                if (group.Name != null)
                {
                    listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group)));
                }
            }

            if (listBoxGroups.Items.Count == 0)
            {
                listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add("You don't have groups yet")));
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            UtilitiesForForm.FetchEvents(m_LoggedInUser, listBoxEvents);
        }

        private void goToProfile_Click(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedIndex != -1)
            {
                User friend = m_LoggedInUser.Friends[listBoxFriends.SelectedIndex];
                FormMain friend_form = new FormMain(friend,true);
                friend_form.ShowDialog();
            }
        }

        public void ButtonPlayClick(object sender, EventArgs e)
        {
            try
            {
                m_SoundManager.PlaySound();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Sound file not found.");
            }
        }

        private void buttonStopClick(object sender, EventArgs e)
        {
            m_SoundManager.StopSound();
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
                    m_SoundManager.SetSoundFile(selectedFilePath);
                    MessageBox.Show("Sound file uploaded successfully.");
                }
            }
        }

        private void buttonAdvancedSearch_Click(object sender, EventArgs e)
        {
            FormAdvancedSearch advancedSearch = new FormAdvancedSearch(m_LoggedInUser);
            advancedSearch.ShowDialog();
            
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            fetchGroups();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxBirthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWork_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
