namespace BasicFacebookFeatures
{
    partial class FormAdvancedSearch
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imageNormalLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.FindFriendsButton = new System.Windows.Forms.Button();
            this.comboBoxMinRange = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxRange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.listBoxFacebook = new System.Windows.Forms.ListBox();
            this.buttonAddLikesPages = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.panelEvent = new System.Windows.Forms.Panel();
            this.panelPage = new System.Windows.Forms.Panel();
            imageNormalLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            imageNormalLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.panelEvent.SuspendLayout();
            this.panelPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageNormalLabel1
            // 
            imageNormalLabel1.AutoSize = true;
            imageNormalLabel1.Location = new System.Drawing.Point(29, 18);
            imageNormalLabel1.Name = "imageNormalLabel1";
            imageNormalLabel1.Size = new System.Drawing.Size(112, 20);
            imageNormalLabel1.TabIndex = 17;
            imageNormalLabel1.Text = "Image Normal:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(53, 74);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(55, 20);
            nameLabel1.TabIndex = 19;
            nameLabel1.Text = "Name:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(42, 112);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Location = new System.Drawing.Point(33, 71);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(112, 20);
            imageNormalLabel.TabIndex = 2;
            imageNormalLabel.Text = "Image Normal:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(33, 21);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(914, 232);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(182, 124);
            this.listBoxFriends.TabIndex = 0;
            // 
            // FindFriendsButton
            // 
            this.FindFriendsButton.Location = new System.Drawing.Point(913, 172);
            this.FindFriendsButton.Name = "FindFriendsButton";
            this.FindFriendsButton.Size = new System.Drawing.Size(183, 42);
            this.FindFriendsButton.TabIndex = 1;
            this.FindFriendsButton.Text = "Find friends";
            this.FindFriendsButton.UseVisualStyleBackColor = true;
            this.FindFriendsButton.Click += new System.EventHandler(this.findFriendsButton_Click);
            // 
            // comboBoxMinRange
            // 
            this.comboBoxMinRange.FormattingEnabled = true;
            this.comboBoxMinRange.Location = new System.Drawing.Point(167, 375);
            this.comboBoxMinRange.Name = "comboBoxMinRange";
            this.comboBoxMinRange.Size = new System.Drawing.Size(132, 28);
            this.comboBoxMinRange.TabIndex = 8;
            this.comboBoxMinRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinRange_SelectedIndexChanged);
            // 
            // comboBoxMaxRange
            // 
            this.comboBoxMaxRange.FormattingEnabled = true;
            this.comboBoxMaxRange.Location = new System.Drawing.Point(341, 376);
            this.comboBoxMaxRange.Name = "comboBoxMaxRange";
            this.comboBoxMaxRange.Size = new System.Drawing.Size(132, 28);
            this.comboBoxMaxRange.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 86);
            this.label1.TabIndex = 10;
            this.label1.Text = "Advanced search:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(95, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(38, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Age range:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(30, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(749, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Let\'s find mutual friends on pages they liked, events and a certain age";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // imageNormalPictureBox1
            // 
            this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox1.Location = new System.Drawing.Point(147, 18);
            this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
            this.imageNormalPictureBox1.Size = new System.Drawing.Size(197, 56);
            this.imageNormalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox1.TabIndex = 18;
            this.imageNormalPictureBox1.TabStop = false;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(147, 74);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(197, 26);
            this.nameTextBox1.TabIndex = 20;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 20;
            this.listBoxLikedPages.Location = new System.Drawing.Point(32, 211);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(265, 144);
            this.listBoxLikedPages.TabIndex = 21;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // listBoxFacebook
            // 
            this.listBoxFacebook.FormattingEnabled = true;
            this.listBoxFacebook.ItemHeight = 20;
            this.listBoxFacebook.Location = new System.Drawing.Point(580, 211);
            this.listBoxFacebook.Name = "listBoxFacebook";
            this.listBoxFacebook.Size = new System.Drawing.Size(179, 144);
            this.listBoxFacebook.TabIndex = 22;
            // 
            // buttonAddLikesPages
            // 
            this.buttonAddLikesPages.Location = new System.Drawing.Point(32, 172);
            this.buttonAddLikesPages.Name = "buttonAddLikesPages";
            this.buttonAddLikesPages.Size = new System.Drawing.Size(145, 34);
            this.buttonAddLikesPages.TabIndex = 23;
            this.buttonAddLikesPages.Text = "AddLIkedPages";
            this.buttonAddLikesPages.UseVisualStyleBackColor = true;
            this.buttonAddLikesPages.Click += new System.EventHandler(this.buttonAddLikesPages_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(580, 172);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(145, 38);
            this.buttonRemove.TabIndex = 24;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddEvents
            // 
            this.buttonAddEvents.Location = new System.Drawing.Point(310, 172);
            this.buttonAddEvents.Name = "buttonAddEvents";
            this.buttonAddEvents.Size = new System.Drawing.Size(145, 34);
            this.buttonAddEvents.TabIndex = 25;
            this.buttonAddEvents.Text = "AddEvents";
            this.buttonAddEvents.UseVisualStyleBackColor = true;
            this.buttonAddEvents.Click += new System.EventHandler(this.buttonAddEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(310, 211);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(245, 144);
            this.listBoxEvents.TabIndex = 26;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(161, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(161, 62);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(173, 41);
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(161, 18);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(173, 26);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // panelEvent
            // 
            this.panelEvent.Controls.Add(descriptionLabel);
            this.panelEvent.Controls.Add(this.descriptionTextBox);
            this.panelEvent.Controls.Add(imageNormalLabel);
            this.panelEvent.Controls.Add(this.imageNormalPictureBox);
            this.panelEvent.Controls.Add(nameLabel);
            this.panelEvent.Controls.Add(this.nameTextBox);
            this.panelEvent.Location = new System.Drawing.Point(35, 431);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(356, 147);
            this.panelEvent.TabIndex = 15;
            this.panelEvent.Visible = false;
            // 
            // panelPage
            // 
            this.panelPage.Controls.Add(imageNormalLabel1);
            this.panelPage.Controls.Add(this.imageNormalPictureBox1);
            this.panelPage.Controls.Add(nameLabel1);
            this.panelPage.Controls.Add(this.nameTextBox1);
            this.panelPage.Location = new System.Drawing.Point(35, 431);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(353, 150);
            this.panelPage.TabIndex = 27;
            this.panelPage.Visible = false;
            // 
            // FormAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1175, 595);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonAddEvents);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddLikesPages);
            this.Controls.Add(this.listBoxFacebook);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.panelEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaxRange);
            this.Controls.Add(this.comboBoxMinRange);
            this.Controls.Add(this.FindFriendsButton);
            this.Controls.Add(this.listBoxFriends);
            this.Name = "FormAdvancedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdvancedSearch";
            this.Load += new System.EventHandler(this.FormAdvancedSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button FindFriendsButton;
        private System.Windows.Forms.ComboBox comboBoxMinRange;
        private System.Windows.Forms.ComboBox comboBoxMaxRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.ListBox listBoxFacebook;
        private System.Windows.Forms.Button buttonAddLikesPages;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.Panel panelPage;
    }
}