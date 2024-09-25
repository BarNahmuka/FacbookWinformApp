using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.BasicFacebookFeatures;
using FacebookLogic;
using FacebookWrapper.ObjectModel;
namespace BasicFacebookFeatures
{
    public partial class FormFacebookCollection<T> : Form
    {
        private readonly GenericFacebookObjectCollection<T> r_FullCollection;
        private BindingList<T> m_InList;

        public FormFacebookCollection(GenericFacebookObjectCollection<T> i_Collection)
        {
            InitializeComponent();
            r_FullCollection = i_Collection;
            m_InList = new BindingList<T>();
            Text = $"{typeof(T).Name}s list";
            initialComponent();
            listBoxCollectionItemsNames.DataSource = m_InList;
            listBoxCollectionItemsNames.DisplayMember = "Name";
            listBoxCollectionItemsNames.Format += (sender, e) =>
                e.Value = typeof(T).GetProperty("Name").GetValue(e.ListItem) ?? "No Name for " + typeof(T).Name;
        }

        private void initialComponent()
        { 
            foreach (T item in r_FullCollection)
            {
                m_InList.Add(item);
            }
        }

        public void DescriptionDataBinding(string i_DataSourceDescriptionProperty)
        {
            labelDescriptionValue.DataBindings.Add(new Binding("Text", listBoxCollectionItemsNames.DataSource, i_DataSourceDescriptionProperty, true));
        }

        public void MainPhotoDataBinding(string i_DataSourceImageProperty)
        {
            pictureBoxItemMainPhoto.DataBindings.Add(new Binding("Image", listBoxCollectionItemsNames.DataSource, i_DataSourceImageProperty, true));
        }

        private void FormFacebookCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
