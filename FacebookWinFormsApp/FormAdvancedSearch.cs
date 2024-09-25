using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicFacebookFeatures
{
    public partial class FormAdvancedSearch : Form
    {
        private User m_LoggedInUser;
        private readonly FacebookFacade r_FacebookFacade;
        private const int k_MinAge = 18;
        private const int k_MaxAge = 100;
        private const string k_DateFormat = "MM/dd/yyyy";
        private const string k_NoFriendsMessage = "You don't liked to any page";
        public FormAdvancedSearch(User i_user, FacebookFacade i_FacebookFacade)
        {
            m_LoggedInUser = i_user;
            InitializeComponent();
            initializeComboBoxes();
            r_FacebookFacade = i_FacebookFacade;
        }

        private void initializeComboBoxes()
        {
            for (int i = k_MinAge; i <= k_MaxAge; i++)
            {
                comboBoxMinRange.Items.Add(i);
            }

            comboBoxMinRange.SelectedIndex = 0;
            comboBoxMinRange.SelectedIndexChanged += comboBoxMinRange_SelectedIndexChanged;
            updateComboBox();
        }

        private void updateComboBox()
        {
            comboBoxMaxRange.Items.Clear();
            int selectedValue = (int)comboBoxMinRange.SelectedItem;

            for (int i = selectedValue; i <= k_MaxAge; i++)
            {
                comboBoxMaxRange.Items.Add(i);
            }

            if (comboBoxMaxRange.Items.Count > 0)
            {
                comboBoxMaxRange.SelectedIndex = 0;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            pageBindingSource.DataSource = m_LoggedInUser.LikedPages;
            eventBindingSource.DataSource = m_LoggedInUser.Events;
        }

        private void findFriendsButton_Click(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            List<User> filterFriendsList = new List<User>();

            foreach (User user in m_LoggedInUser.Friends)
            {
                filterFriendsList.Add(user);
            }

            filterFriendsList = FilterFriends(filterFriendsList);

            foreach (User friends in filterFriendsList)
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

        public List<User> FilterFriends(List<User> i_FriendsList)
        {
            List<FacebookObject> facbookObject = listBoxFacebook.Items.OfType<FacebookObject>().ToList();
           int minAgeIndex = comboBoxMinRange.SelectedIndex;
           int maxAgeIndex = comboBoxMaxRange.SelectedIndex;
           int minAge = Convert.ToInt32(comboBoxMinRange.Items[minAgeIndex]);
           int maxAge = Convert.ToInt32(comboBoxMaxRange.Items[maxAgeIndex]);
           List<User> filteredList = r_FacebookFacade.GetFriendsByFilter(i_FriendsList, minAge, maxAge, facbookObject);

           return filteredList;
        }

        private bool inAgeRange(User i_friend, int i_MinAge, int i_MaxAge)
        {
            bool inRange = false;
            DateTime time = DateTime.Now;

            try
            {
                string format = "MM/dd/yyyy";
                DateTime userBirthday = DateTime.ParseExact(i_friend.Birthday, format, CultureInfo.InvariantCulture);
                int age = time.Year - userBirthday.Year;

                age = time.Month < userBirthday.Month ||
                    (time.Month == userBirthday.Month && time.Day < userBirthday.Day) ?
                    age - 1 : age;
                inRange = age <= i_MaxAge && age >= i_MinAge;
            }
            catch (Exception)
            {
                inRange = false;
            }

            return inRange;
        }

        private void comboBoxMinRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComboBox();
        }

        private void buttonAddEvents_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedIndex != -1)
            {
                listBoxFacebook.Items.Add(listBoxEvents.SelectedItem as FacebookObject);
            }
        }

        private void buttonAddLikesPages_Click(object sender, EventArgs e)
        {
            if(listBoxLikedPages.SelectedIndex != -1) 
            {
                listBoxFacebook.Items.Add(listBoxLikedPages.SelectedItem as FacebookObject);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxFacebook.SelectedIndex != -1)
            {
                listBoxFacebook.Items.Remove(listBoxFacebook.SelectedItem);
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelPage.Visible = true;
            panelEvent.Visible = false;
        }

        private void FormAdvancedSearch_Load(object sender, EventArgs e)
        {

        }
    }
}