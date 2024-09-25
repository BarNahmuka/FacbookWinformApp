namespace BasicFacebookFeatures
{
    partial class FormFacebookCollection<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCollectionItemsNames = new System.Windows.Forms.ListBox();
            this.pictureBoxItemMainPhoto = new System.Windows.Forms.PictureBox();
            this.labelDescriptionValue = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemMainPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCollectionItemsNames
            // 
            this.listBoxCollectionItemsNames.FormattingEnabled = true;
            this.listBoxCollectionItemsNames.ItemHeight = 20;
            this.listBoxCollectionItemsNames.Location = new System.Drawing.Point(285, 202);
            this.listBoxCollectionItemsNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxCollectionItemsNames.Name = "listBoxCollectionItemsNames";
            this.listBoxCollectionItemsNames.Size = new System.Drawing.Size(259, 224);
            this.listBoxCollectionItemsNames.TabIndex = 0;
            // 
            // pictureBoxItemMainPhoto
            // 
            this.pictureBoxItemMainPhoto.Location = new System.Drawing.Point(642, 58);
            this.pictureBoxItemMainPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxItemMainPhoto.Name = "pictureBoxItemMainPhoto";
            this.pictureBoxItemMainPhoto.Size = new System.Drawing.Size(224, 226);
            this.pictureBoxItemMainPhoto.TabIndex = 2;
            this.pictureBoxItemMainPhoto.TabStop = false;
            // 
            // labelDescriptionValue
            // 
            this.labelDescriptionValue.AutoSize = true;
            this.labelDescriptionValue.Location = new System.Drawing.Point(638, 408);
            this.labelDescriptionValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionValue.Name = "labelDescriptionValue";
            this.labelDescriptionValue.Size = new System.Drawing.Size(51, 20);
            this.labelDescriptionValue.TabIndex = 3;
            this.labelDescriptionValue.Text = "label1";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(642, 328);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(93, 20);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description:";
            // 
            // FormFacebookCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDescriptionValue);
            this.Controls.Add(this.pictureBoxItemMainPhoto);
            this.Controls.Add(this.listBoxCollectionItemsNames);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFacebookCollection";
            this.Text = "FormFacebookCollection";
            this.Load += new System.EventHandler(this.FormFacebookCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemMainPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCollectionItemsNames;
        private System.Windows.Forms.PictureBox pictureBoxItemMainPhoto;
        private System.Windows.Forms.Label labelDescriptionValue;
        private System.Windows.Forms.Label labelDescription;
    }
}