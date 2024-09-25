using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    class AdvancedSearchLogic
    {
        public List<User> FilterByAge(List<User> i_FilterFriendsList, int i_MinAge, int i_MaxAge)
        {
            List<User> ListAge = new List<User>();

            foreach (User user in i_FilterFriendsList)
            {
                if (inAgeRange(user, i_MinAge, i_MaxAge))
                {
                    ListAge.Add(user);
                }
            }

            return ListAge;
        }

        public List<User> FilterLikedPages(List<User> i_FilterFriendsList, List<Page> i_SelectedPages)
        {
            List<User> ListLikedPages = new List<User>();

            if (i_SelectedPages.Count == 0)
            {
                return i_FilterFriendsList;
            }

            foreach (User friend in i_FilterFriendsList)
            {
                bool hasAllPages = true;

                foreach (Page selectedPage in i_SelectedPages)
                {
                    if (!friend.LikedPages.Any(page => page.Name == selectedPage.Name))
                    {
                        hasAllPages = false;
                        break;
                    }
                }

                if (hasAllPages)
                {
                    ListLikedPages.Add(friend);
                }
            }

            return ListLikedPages;
        }

        public List<User> FilterEvents(List<User> i_FilterFriendsList, List<Event> i_SelectedEvents)
        {
            if (i_SelectedEvents.Count == 0)
            {
                return i_FilterFriendsList;
            }

            List<User> filteredFriends = new List<User>();

            foreach (User friend in i_FilterFriendsList)
            {
                bool hasMatchingEvent = friend.Events.Any(friendEvent => i_SelectedEvents.Contains(friendEvent));

                if (hasMatchingEvent)
                {
                    filteredFriends.Add(friend);
                }
            }

            return filteredFriends;
        }

        public static void SeparateFacebookObjectsByType (List<FacebookObject> i_FacebookObject, ref List<Page> io_SelectedPages, ref List<Event> io_SelectedEvents)
        {
            foreach(FacebookObject facebookObject in i_FacebookObject) 
            {
                if(facebookObject is Event)
                {
                    io_SelectedEvents.Add(facebookObject as Event);
                }
                else if (facebookObject is Page)
                {
                    io_SelectedPages.Add(facebookObject as Page);
                }
            }
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
    }
}
