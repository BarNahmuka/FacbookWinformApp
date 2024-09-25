using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BasicFacebookFeatures
{
    public partial class FormAlbums : Form
    {
        private User m_User;

        public FormAlbums(User i_User)
        {
            InitializeComponent();
            m_User = i_User;
        }

        private void albumsForm_Load(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            new Thread(() => fetchAlbums()).Start();

        }
   
        private void fetchAlbums()
        {
            int pictureBoxSize = 200;
            int labelWidth = 100;
            int margin = 20;
            int titleHeight = 50;
            int currentTop = titleHeight + margin;
            int currentLeft = margin;
            int albumsPerRow = 3;
            Label titleLabel = new Label();
            titleLabel.Text = "My Albums:";
            titleLabel.Font = new Font("Arial", 20, FontStyle.Bold);
            titleLabel.TextAlign = ContentAlignment.TopLeft;
            titleLabel.Width = this.Width;
            titleLabel.Height = 50;
            titleLabel.Top = 0;
            this.Invoke(new Action(() => this.Controls.Add(titleLabel)));
            Panel panelAlbums = new Panel();
            panelAlbums.AutoScroll = true;
            panelAlbums.Dock = DockStyle.Fill;
            this.Invoke(new Action(() => this.Controls.Add(panelAlbums)));
            int albumCount = 0;

            foreach (Album album in m_User.Albums)
            {
                if (album.Name != null && album.PictureAlbumURL != null)
                {
                    LinkLabel linkLabelAlbumName = new LinkLabel();
                    linkLabelAlbumName.Text = album.Name;
                    linkLabelAlbumName.Width = pictureBoxSize;
                    linkLabelAlbumName.Height = 30;
                    linkLabelAlbumName.Top = currentTop - 20;
                    linkLabelAlbumName.Left = currentLeft;
                    linkLabelAlbumName.TextAlign = ContentAlignment.MiddleLeft;
                    linkLabelAlbumName.Font = new Font("Arial", 14, FontStyle.Regular); 
                    PictureBox pictureBoxAlbum = new PictureBox();
                    pictureBoxAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxAlbum.ImageLocation = album.PictureAlbumURL;
                    pictureBoxAlbum.Width = pictureBoxSize;
                    pictureBoxAlbum.Height = pictureBoxSize;
                    pictureBoxAlbum.Top = currentTop;
                    pictureBoxAlbum.Left = currentLeft;
                    pictureBoxAlbum.BorderStyle = BorderStyle.FixedSingle;

                    linkLabelAlbumName.Click += (sender, e) =>
                    {
                        FormPhotos photosForm = new FormPhotos(album);
                        photosForm.ShowDialog();
                    };

                    this.Invoke(new Action(() =>
                    {
                        panelAlbums.Controls.Add(linkLabelAlbumName);
                        panelAlbums.Controls.Add(pictureBoxAlbum);
                    }));

                    albumCount++;
                    if (albumCount % albumsPerRow == 0)
                    {
                        currentTop += pictureBoxSize + 2 * margin;
                        currentLeft = margin;
                    }
                    else
                    {
                        currentLeft += pictureBoxSize + margin;
                    }
                }
            }

            if (panelAlbums.Controls.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxCommentsPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}