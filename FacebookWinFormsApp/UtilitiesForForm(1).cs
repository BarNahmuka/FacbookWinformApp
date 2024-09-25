using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class UtilitiesForForm
    {
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

        public static void FetchLikedPages(User i_User, ListBox i_CheckedListBoxLikedPages )
        {
            foreach (FacebookWrapper.ObjectModel.Page likedPages in i_User.LikedPages)
            {
                if (likedPages.Name != null)
                {
                    i_CheckedListBoxLikedPages.Invoke(new Action(() => i_CheckedListBoxLikedPages.Items.Add(likedPages.Name)));
                }
            }

            if (i_CheckedListBoxLikedPages.Items.Count == 0)
            {
                i_CheckedListBoxLikedPages.Invoke(new Action(() => i_CheckedListBoxLikedPages.Items.Add("You don't liked to any page")));
            }
        }

        public static void FetchEvents(User i_User, ListBox i_CheckedListBoxEvents)
        {
            foreach (Event events in i_User.Events)
            {
                if (events.Name != null)
                {
                    i_CheckedListBoxEvents.Invoke(new Action(() => i_CheckedListBoxEvents.Items.Add(events)));
                }
            }

            if (i_CheckedListBoxEvents.Items.Count == 0)
            {
                i_CheckedListBoxEvents.Invoke(new Action(() => i_CheckedListBoxEvents.Items.Add("You don't have events yet")));
            }
        }
    }
}
