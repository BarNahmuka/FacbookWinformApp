using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPhotos : Form
    {
        private Album m_SelectedAlbum;

        public FormPhotos(Album selectedAlbum)
        {
            InitializeComponent();
            m_SelectedAlbum = selectedAlbum;
        }

        private void photosForm_Load(object sender, EventArgs e)
        {
            int widthSpaceSeparation = 30;
            int heightSpaceSeparation = 30;
            int newLocationX = 10;
            int newLocationY = 10;
            Size pictureBoxSize = new Size(100, 100);

            foreach (Photo picture in m_SelectedAlbum.Photos)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = pictureBoxSize;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.LoadAsync(picture.PictureAlbumURL);

                if (newLocationX + pictureBox.Size.Width >= this.Size.Width - 30)
                {
                    newLocationX = 10;
                    newLocationY += pictureBox.Size.Height + heightSpaceSeparation;
                }

                pictureBox.Location = new Point(newLocationX, newLocationY);
                newLocationX += pictureBox.Size.Width + widthSpaceSeparation;
                this.Controls.Add(pictureBox);
            }

            Label pressOnThePictureLabel = new Label();
            pressOnThePictureLabel.Location = new Point(30, newLocationY + pictureBoxSize.Height + 60);
            pressOnThePictureLabel.AutoSize = true;
            pressOnThePictureLabel.Font = new Font("Arial", 20);
            this.Controls.Add(pressOnThePictureLabel);
        }
    }
}

