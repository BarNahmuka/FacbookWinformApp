using BasicFacebookFeatures.BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class CollectionFormFactory
    {
        public static Form CreateForm(User i_LoggedInUser, eCollectionFormType i_FormType)
        {
            Form form;

            switch (i_FormType)
            {
                case eCollectionFormType.GroupsForm:
                    form = new FormFacebookCollection<Group>(new GenericFacebookObjectCollection<Group>(i_LoggedInUser.Groups));
                    ((FormFacebookCollection<Group>)form).DescriptionDataBinding("Description");
                    ((FormFacebookCollection<Group>)form).MainPhotoDataBinding("ImageNormal");
                    break;
                case eCollectionFormType.LikedPagesForm:
                    form = new FormFacebookCollection<Page>(new GenericFacebookObjectCollection<Page>(i_LoggedInUser.LikedPages));
                    ((FormFacebookCollection<Page>)form).DescriptionDataBinding("Description");
                    ((FormFacebookCollection<Page>)form).MainPhotoDataBinding("ImageNormal");
                    break;
                case eCollectionFormType.EventsForm:
                    form = new FormFacebookCollection<Event>(new GenericFacebookObjectCollection<Event>(i_LoggedInUser.Events));
                    ((FormFacebookCollection<Event>)form).DescriptionDataBinding("Description");
                    ((FormFacebookCollection<Event>)form).MainPhotoDataBinding("ImageNormal");
                    break;

                default:
                    throw new Exception();
            }

            return form;
        }
    }
}
