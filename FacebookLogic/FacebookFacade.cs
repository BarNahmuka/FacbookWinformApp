using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace FacebookLogic
{
    public class FacebookFacade
    {
        private AdvancedSearchLogic m_AdvancedSearchLogic;
        private SoundManager m_SoundManager;
        private iAbout m_AboutUserAdapter;

        public List<String> GetUserDetails(User i_User)
        {
            m_AboutUserAdapter = new AboutUserAdapter(i_User);
            return m_AboutUserAdapter.AboutUser();
        }

        public void RememberUser(string i_Token)
        {
            new UserIdentification(i_Token).SaveToFile();
        }

        public string GetSaveUser()
        {
            return UserIdentification.LoadFromFile();
        }

        public void ForgetUser()
        {
            UserIdentification.EraseTokenFile();
        }

        public void InitializeSoundManager(string i_User)
        {
            m_SoundManager = SoundManager.Instance;
            m_SoundManager.Initialize(i_User);
        }

        public void SwitchSoundManagerUser(string i_User)
        {
            m_SoundManager.SwitchUser(i_User);
        }

        public void RevertSoundManagerUser()
        {
            m_SoundManager.RevertToPreviousUser();
        }

        public void CheckIfSongAvailable(string i_User)
        {
            InitializeSoundManager(i_User); 
        }

        public void PlaySong()
        {
            m_SoundManager.PlaySound();
        }

        public void StopSong()
        {
            m_SoundManager.StopSound();
        }

        public void UploadSong(string i_Song)
        {
            m_SoundManager.SetSoundFile(i_Song);
        }

        public List<User> GetFriendsByFilter(List<User> i_FilterFriendsList, int i_MinAge, int i_MaxAge, List<FacebookObject> i_SelectedToFilter)
        {
            if (m_AdvancedSearchLogic == null)
            {
                m_AdvancedSearchLogic = new AdvancedSearchLogic();
            }

            List<Page> selectedPage = new List<Page>();
            List<Event> selectedEvent = new List<Event>();
            AdvancedSearchLogic.SeparateFacebookObjectsByType(i_SelectedToFilter, ref selectedPage, ref selectedEvent);

            i_FilterFriendsList = FetchSimilarFriends(i_FilterFriendsList, i_MinAge, i_MaxAge, selectedPage, selectedEvent);

            return i_FilterFriendsList;
        }

        private List<User> FetchSimilarFriends(List<User> i_FilterFriendsList, int i_MinAge, int i_MaxAge, List<Page> selectedPages, List<Event> selectedEvents)
        {
            i_FilterFriendsList = m_AdvancedSearchLogic.FilterByAge(i_FilterFriendsList, i_MinAge, i_MaxAge);
            i_FilterFriendsList = m_AdvancedSearchLogic.FilterLikedPages(i_FilterFriendsList, selectedPages);
            i_FilterFriendsList = m_AdvancedSearchLogic.FilterEvents(i_FilterFriendsList, selectedEvents);

            return i_FilterFriendsList;
        }


        public void RememberUserStatus(bool i_CheckedRememberME, string i_Token)
        {
            if (i_CheckedRememberME)
            {
                RememberUser(i_Token);
            }
            else
            {
                ForgetUser();
            }
        }
        public static void DisplayCover(String pic, ListBox list, PictureBox pictureBox)
        {
            if (list.SelectedItems.Count == 1)
            {
                if (pic != null)
                {
                    pictureBox.LoadAsync(pic);
                }
                else
                {
                    pictureBox.Image = pictureBox.ErrorImage;
                }
            }
        }
    }
}
