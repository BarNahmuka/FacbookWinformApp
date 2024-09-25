using System;
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
        public FormAdvancedSearch(User i_user)
        {
            m_LoggedInUser = i_user;
            InitializeComponent();
            initializeComboBoxes();
        }

        private void initializeComboBoxes()
        {
            for (int i = 18; i <= 100; i++)
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

            for (int i = selectedValue; i <= 100; i++)
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
            UtilitiesForForm.FetchLikedPages(m_LoggedInUser, checkedListBoxLikedPages);
            UtilitiesForForm.FetchEvents(m_LoggedInUser, checkedListBoxEvents);
        }

        private void checkedListBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findFriendsButton_Click(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            List<User> filterFriendsList = new List<User>();

            foreach (User user in m_LoggedInUser.Friends)
            {
                filterFriendsList.Add(user);
            }

            filterFriendsList = getFriendsWithSimilarPages(filterFriendsList);
            filterFriendsList = getFriendsWithSimilarEvents(filterFriendsList);
            filterFriendsList = getFriendsWithinAgeRange(filterFriendsList);

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

        private List<User> getFriendsWithinAgeRange(List<User> i_filterFriendsList)
        {
            List<User> filterByAge = new List<User>();

            if (comboBoxMinRange.SelectedIndex == -1)
            {
                filterByAge = i_filterFriendsList;
            }
            else
            {
                int minAgeIndex = comboBoxMinRange.SelectedIndex;
                int maxAgeIndex = comboBoxMaxRange.SelectedIndex;
                int minAge = Convert.ToInt32(comboBoxMinRange.Items[minAgeIndex]);
                int maxAge = Convert.ToInt32(comboBoxMaxRange.Items[maxAgeIndex]);

                foreach (User friend in i_filterFriendsList)
                {
                    if (inAgeRange(friend, minAge, maxAge) )
                    {
                        filterByAge.Add(friend);
                    }
                }
            }

            return filterByAge;
        }

        private List<User> getFriendsWithSimilarPages(List<User> i_FilterFriendsList)
        {
            List<User> filterByPages = new List<User>();

            if (checkedListBoxLikedPages.SelectedIndex == -1)
            {
                filterByPages = i_FilterFriendsList;
            }
            else
            {
                List<string> selectedPages = checkedListBoxLikedPages.CheckedItems.Cast<string>().ToList();

                foreach (User friend in i_FilterFriendsList)
                {
                    bool hasAllPages = true;

                    foreach (string selectedPage in selectedPages)
                    {
                        if (!friend.LikedPages.Any(friendPage => friendPage.Name == selectedPage))
                        {
                            hasAllPages = false;
                            break;
                        }
                    }

                    if (hasAllPages)
                    {
                        filterByPages.Add(friend);
                    }
                }
            }

            return filterByPages;
        }

        private List<User> getFriendsWithSimilarEvents(List<User> i_FilterFriendsList)
        {
            List<User> filterByEvents = new List<User>();

            if (checkedListBoxEvents.SelectedIndex == -1)
            {
                filterByEvents = i_FilterFriendsList;
            }

            else
            {
                foreach (User friend in i_FilterFriendsList)
                {
                    foreach (Event events in checkedListBoxEvents.Items)
                    {
                        foreach (Event friendEvent in friend.Events)
                        {
                            filterByEvents.Add(friend);
                        }
                    }
                }
            }

            return filterByEvents;
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


        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxMinRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComboBox();
        }

        private void comboBoxMaxRange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}