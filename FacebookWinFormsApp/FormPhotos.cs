using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPhotos : Form
    {
        private const int WidthSpaceSeparation = 30;
        private const int HeightSpaceSeparation = 30;
        private const int InitialLocationX = 10;
        private const int InitialLocationY = 10;
        private const int PictureBoxWidth = 100;
        private const int PictureBoxHeight = 100;
        private const int LabelYOffset = 60;
        private const string FontName = "Arial";
        private const int FontSize = 20;

        private Album m_SelectedAlbum;

        public FormPhotos(Album selectedAlbum)
        {
            InitializeComponent();
            m_SelectedAlbum = selectedAlbum;
        }

        private void photosForm_Load(object sender, EventArgs e)
        {
            int newLocationX = InitialLocationX;
            int newLocationY = InitialLocationY;
            Size pictureBoxSize = new Size(PictureBoxWidth, PictureBoxHeight);

            foreach (Photo picture in m_SelectedAlbum.Photos)
            {
                PictureBox pictureBox = CreatePictureBox(picture, pictureBoxSize);
                UpdatePictureBoxLocation(ref newLocationX, ref newLocationY, pictureBox);
                this.Controls.Add(pictureBox);
            }

            Label pressOnThePictureLabel = CreateLabel(newLocationY + pictureBoxSize.Height + LabelYOffset);
            this.Controls.Add(pressOnThePictureLabel);
        }

        private PictureBox CreatePictureBox(Photo i_Picture, Size i_Size)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = i_Size;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.LoadAsync(i_Picture.PictureAlbumURL);
            return pictureBox;
        }

        private void UpdatePictureBoxLocation(ref int io_NewLocationX, ref int io_NewLocationY, PictureBox i_PictureBox)
        {
            if (io_NewLocationX + i_PictureBox.Size.Width >= this.Size.Width - WidthSpaceSeparation)
            {
                io_NewLocationX = InitialLocationX;
                io_NewLocationY += i_PictureBox.Size.Height + HeightSpaceSeparation;
            }

            i_PictureBox.Location = new Point(io_NewLocationX, io_NewLocationY);
            io_NewLocationX += i_PictureBox.Size.Width + WidthSpaceSeparation;
        }

        private Label CreateLabel(int i_Top)
        {
            Label label = new Label();
            label.Location = new Point(InitialLocationX, i_Top);
            label.AutoSize = true;
            label.Font = new Font(FontName, FontSize);
            return label;
        }
    }
}
