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
        private const int k_PictureBoxSize = 200;
        private const int k_LabelWidth = 100;
        private const int k_Margin = 20;
        private const int k_TitleHeight = 50;
        private const int k_FontSize = 20;
        private const int k_AlbumsPerRow = 3;
        private const string k_TitleText = "My Albums:";
        private const string k_NoAlbumsMessage = "No Albums to retrieve :(";
        private const string k_FetchAlbumsErrorMessage = "Failed to retrieve albums. Error: ";
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
            try
            {
                Label titleLabel = CreateTitleLabel();
                Panel panelAlbums = CreatePanel();

                this.Invoke(new Action(() =>
                {
                    this.Controls.Add(titleLabel);
                    this.Controls.Add(panelAlbums);
                }));

                int currentTop = k_TitleHeight + k_Margin;
                int currentLeft = k_Margin;
                int albumCount = 0;

                foreach (Album album in m_User.Albums)
                {
                    if (album.Name != null && album.PictureAlbumURL != null)
                    {
                        AddAlbumControlToPanel(panelAlbums, album, ref currentTop, ref currentLeft, ref albumCount);
                    }
                }

                if (panelAlbums.Controls.Count == 0)
                {
                    ShowNoAlbumsMessage();
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show($"{k_FetchAlbumsErrorMessage} {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private Label CreateTitleLabel()
        {
            Label titleLabel = new Label();
            titleLabel.Text = k_TitleText;
            titleLabel.Font = new Font("Arial", k_FontSize, FontStyle.Bold);
            titleLabel.TextAlign = ContentAlignment.TopLeft;
            titleLabel.Width = this.Width;
            titleLabel.Height = k_TitleHeight;
            titleLabel.Top = 0;
            return titleLabel;
        }

        private Panel CreatePanel()
        {
            Panel panelAlbums = new Panel();
            panelAlbums.AutoScroll = true;
            panelAlbums.Dock = DockStyle.Fill;
            return panelAlbums;
        }

        private void AddAlbumControlToPanel(Panel i_PanelAlbums, Album i_Album, ref int io_CurrentTop, ref int io_CurrentLeft, ref int io_AlbumCount)
        {
            LinkLabel linkLabelAlbumName = CreateAlbumLinkLabel(i_Album, io_CurrentTop, io_CurrentLeft);
            PictureBox pictureBoxAlbum = CreateAlbumPictureBox(i_Album, io_CurrentTop, io_CurrentLeft);

            this.Invoke(new Action(() =>
            {
                i_PanelAlbums.Controls.Add(linkLabelAlbumName);
                i_PanelAlbums.Controls.Add(pictureBoxAlbum);
            }));

            io_AlbumCount++;
            if (io_AlbumCount % k_AlbumsPerRow == 0)
            {
                io_CurrentTop += k_PictureBoxSize + 2 * k_Margin;
                io_CurrentLeft = k_Margin;
            }
            else
            {
                io_CurrentLeft += k_PictureBoxSize + k_Margin;
            }
        }

        private LinkLabel CreateAlbumLinkLabel(Album i_Album, int i_Top, int i_Left)
        {
            LinkLabel linkLabelAlbumName = new LinkLabel();
            linkLabelAlbumName.Text = i_Album.Name;
            linkLabelAlbumName.Width = k_PictureBoxSize;
            linkLabelAlbumName.Height = 30;
            linkLabelAlbumName.Top = i_Top - 20;
            linkLabelAlbumName.Left = i_Left;
            linkLabelAlbumName.TextAlign = ContentAlignment.MiddleLeft;
            linkLabelAlbumName.Font = new Font("Arial", 14, FontStyle.Regular);

            linkLabelAlbumName.Click += (sender, e) =>
            {
                FormPhotos photosForm = new FormPhotos(i_Album);
                photosForm.ShowDialog();
            };

            return linkLabelAlbumName;
        }

        private PictureBox CreateAlbumPictureBox(Album i_Album, int i_Top, int i_Left)
        {
            PictureBox pictureBoxAlbum = new PictureBox();
            pictureBoxAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAlbum.ImageLocation = i_Album.PictureAlbumURL;
            pictureBoxAlbum.Width = k_PictureBoxSize;
            pictureBoxAlbum.Height = k_PictureBoxSize;
            pictureBoxAlbum.Top = i_Top;
            pictureBoxAlbum.Left = i_Left;
            pictureBoxAlbum.BorderStyle = BorderStyle.FixedSingle;
            return pictureBoxAlbum;
        }

        private void ShowNoAlbumsMessage()
        {
            this.Invoke(new Action(() => MessageBox.Show(k_NoAlbumsMessage)));
        }
    }
}
