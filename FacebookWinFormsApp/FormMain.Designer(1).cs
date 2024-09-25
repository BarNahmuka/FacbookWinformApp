
namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonLikePages = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.buttonGoToFriendProfile = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonUploadNewSong = new System.Windows.Forms.Button();
            this.buttonAdvancedSearch = new System.Windows.Forms.Button();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.labelMyFriends = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.labelPosts = new System.Windows.Forms.Label();
            this.textBoxWork = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(18, 18);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(213, 42);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(461, 58);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(226, 108);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 26;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 180);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(439, 82);
            this.listBoxPosts.TabIndex = 57;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 92;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(337, 458);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 108);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 59;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 58);
            this.button1.TabIndex = 62;
            this.button1.Text = "Show all my albums";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAlbum_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 26;
            this.listBoxLikedPages.Location = new System.Drawing.Point(36, 342);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(266, 82);
            this.listBoxLikedPages.TabIndex = 64;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.ListBoxLikedPages_SelectedIndexChanged);
            // 
            // buttonLikePages
            // 
            this.buttonLikePages.Location = new System.Drawing.Point(36, 309);
            this.buttonLikePages.Name = "buttonLikePages";
            this.buttonLikePages.Size = new System.Drawing.Size(266, 36);
            this.buttonLikePages.TabIndex = 65;
            this.buttonLikePages.Text = "Show all my liked pages";
            this.buttonLikePages.UseVisualStyleBackColor = true;
            this.buttonLikePages.Click += new System.EventHandler(this.buttonLikedGroups_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(439, 306);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(264, 36);
            this.buttonEvents.TabIndex = 66;
            this.buttonEvents.Text = "Show all my events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 26;
            this.listBoxEvents.Location = new System.Drawing.Point(439, 342);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(264, 82);
            this.listBoxEvents.TabIndex = 67;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 26;
            this.listBoxFriends.Location = new System.Drawing.Point(1009, 60);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(148, 160);
            this.listBoxFriends.TabIndex = 68;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(998, 119);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(0, 26);
            this.labelFriends.TabIndex = 69;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(739, 26);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(0, 26);
            this.labelAbout.TabIndex = 70;
            // 
            // buttonGoToFriendProfile
            // 
            this.buttonGoToFriendProfile.Location = new System.Drawing.Point(1008, 226);
            this.buttonGoToFriendProfile.Name = "buttonGoToFriendProfile";
            this.buttonGoToFriendProfile.Size = new System.Drawing.Size(148, 63);
            this.buttonGoToFriendProfile.TabIndex = 80;
            this.buttonGoToFriendProfile.Text = "Go To friend profile";
            this.buttonGoToFriendProfile.UseVisualStyleBackColor = true;
            this.buttonGoToFriendProfile.Click += new System.EventHandler(this.goToProfile_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(623, 458);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(89, 41);
            this.buttonPlay.TabIndex = 81;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlayClick);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(753, 458);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(91, 41);
            this.buttonStop.TabIndex = 82;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStopClick);
            // 
            // buttonUploadNewSong
            // 
            this.buttonUploadNewSong.Location = new System.Drawing.Point(623, 519);
            this.buttonUploadNewSong.Name = "buttonUploadNewSong";
            this.buttonUploadNewSong.Size = new System.Drawing.Size(221, 47);
            this.buttonUploadNewSong.TabIndex = 83;
            this.buttonUploadNewSong.Text = "Upload new song";
            this.buttonUploadNewSong.UseVisualStyleBackColor = true;
            this.buttonUploadNewSong.Click += new System.EventHandler(this.uploadNewSongClick);
            // 
            // buttonAdvancedSearch
            // 
            this.buttonAdvancedSearch.Location = new System.Drawing.Point(892, 478);
            this.buttonAdvancedSearch.Name = "buttonAdvancedSearch";
            this.buttonAdvancedSearch.Size = new System.Drawing.Size(265, 58);
            this.buttonAdvancedSearch.TabIndex = 84;
            this.buttonAdvancedSearch.Text = "Advanced search";
            this.buttonAdvancedSearch.UseVisualStyleBackColor = true;
            this.buttonAdvancedSearch.Click += new System.EventHandler(this.buttonAdvancedSearch_Click);
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(712, 64);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(258, 32);
            this.textBoxBirthday.TabIndex = 73;
            this.textBoxBirthday.TextChanged += new System.EventHandler(this.textBoxBirthday_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(712, 102);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(258, 32);
            this.textBoxEmail.TabIndex = 74;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(712, 140);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(258, 32);
            this.textBoxLocation.TabIndex = 71;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(461, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(226, 32);
            this.textBoxName.TabIndex = 86;
            // 
            // buttonGroups
            // 
            this.buttonGroups.Location = new System.Drawing.Point(821, 306);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(263, 36);
            this.buttonGroups.TabIndex = 77;
            this.buttonGroups.Text = "Show all my groups";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 26;
            this.listBoxGroups.Location = new System.Drawing.Point(822, 342);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(262, 82);
            this.listBoxGroups.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 85;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Location = new System.Drawing.Point(707, 26);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(112, 26);
            this.labelAboutMe.TabIndex = 87;
            this.labelAboutMe.Text = "About me:";
            // 
            // labelMyFriends
            // 
            this.labelMyFriends.AutoSize = true;
            this.labelMyFriends.Location = new System.Drawing.Point(1004, 29);
            this.labelMyFriends.Name = "labelMyFriends";
            this.labelMyFriends.Size = new System.Drawing.Size(118, 26);
            this.labelMyFriends.TabIndex = 88;
            this.labelMyFriends.Text = "My friends:";
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 26;
            this.listBoxComments.Location = new System.Drawing.Point(476, 198);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(211, 30);
            this.listBoxComments.TabIndex = 89;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(17, 145);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(105, 26);
            this.labelPosts.TabIndex = 90;
            this.labelPosts.Text = "My posts:";
            // 
            // textBoxWork
            // 
            this.textBoxWork.Location = new System.Drawing.Point(712, 180);
            this.textBoxWork.Name = "textBoxWork";
            this.textBoxWork.Size = new System.Drawing.Size(258, 32);
            this.textBoxWork.TabIndex = 72;
            this.textBoxWork.TextChanged += new System.EventHandler(this.textBoxWork_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1190, 592);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.labelMyFriends);
            this.Controls.Add(this.labelAboutMe);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxWork);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.buttonAdvancedSearch);
            this.Controls.Add(this.buttonUploadNewSong);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonGoToFriendProfile);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.buttonLikePages);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelAbout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonLikePages;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Button buttonGoToFriendProfile;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonUploadNewSong;
        private System.Windows.Forms.Button buttonAdvancedSearch;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelAboutMe;
        private System.Windows.Forms.Label labelMyFriends;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.TextBox textBoxWork;
    }
}