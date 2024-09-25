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
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.FindFriendsButton = new System.Windows.Forms.Button();
            this.checkedListBoxLikedPages = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxEvents = new System.Windows.Forms.CheckedListBox();
            this.comboBoxMinRange = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxRange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(677, 228);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(182, 204);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // FindFriendsButton
            // 
            this.FindFriendsButton.Location = new System.Drawing.Point(676, 180);
            this.FindFriendsButton.Name = "FindFriendsButton";
            this.FindFriendsButton.Size = new System.Drawing.Size(183, 42);
            this.FindFriendsButton.TabIndex = 1;
            this.FindFriendsButton.Text = "Find friends";
            this.FindFriendsButton.UseVisualStyleBackColor = true;
            this.FindFriendsButton.Click += new System.EventHandler(this.findFriendsButton_Click);
            // 
            // checkedListBoxLikedPages
            // 
            this.checkedListBoxLikedPages.FormattingEnabled = true;
            this.checkedListBoxLikedPages.Location = new System.Drawing.Point(35, 228);
            this.checkedListBoxLikedPages.Name = "checkedListBoxLikedPages";
            this.checkedListBoxLikedPages.Size = new System.Drawing.Size(266, 211);
            this.checkedListBoxLikedPages.TabIndex = 6;
            this.checkedListBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxLikedPages_SelectedIndexChanged);
            // 
            // checkedListBoxEvents
            // 
            this.checkedListBoxEvents.FormattingEnabled = true;
            this.checkedListBoxEvents.Location = new System.Drawing.Point(346, 228);
            this.checkedListBoxEvents.Name = "checkedListBoxEvents";
            this.checkedListBoxEvents.Size = new System.Drawing.Size(266, 211);
            this.checkedListBoxEvents.TabIndex = 7;
            this.checkedListBoxEvents.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEvents_SelectedIndexChanged);
            // 
            // comboBoxMinRange
            // 
            this.comboBoxMinRange.FormattingEnabled = true;
            this.comboBoxMinRange.Location = new System.Drawing.Point(224, 477);
            this.comboBoxMinRange.Name = "comboBoxMinRange";
            this.comboBoxMinRange.Size = new System.Drawing.Size(132, 28);
            this.comboBoxMinRange.TabIndex = 8;
            this.comboBoxMinRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinRange_SelectedIndexChanged);
            // 
            // comboBoxMaxRange
            // 
            this.comboBoxMaxRange.FormattingEnabled = true;
            this.comboBoxMaxRange.Location = new System.Drawing.Point(398, 478);
            this.comboBoxMaxRange.Name = "comboBoxMaxRange";
            this.comboBoxMaxRange.Size = new System.Drawing.Size(132, 28);
            this.comboBoxMaxRange.TabIndex = 9;
            this.comboBoxMaxRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaxRange_SelectedIndexChanged);
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
            this.label2.Location = new System.Drawing.Point(91, 477);
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
            // FormAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaxRange);
            this.Controls.Add(this.comboBoxMinRange);
            this.Controls.Add(this.checkedListBoxEvents);
            this.Controls.Add(this.checkedListBoxLikedPages);
            this.Controls.Add(this.FindFriendsButton);
            this.Controls.Add(this.listBoxFriends);
            this.Name = "FormAdvancedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdvancedSearch";
            this.Load += new System.EventHandler(this.AdvancedSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button FindFriendsButton;
        private System.Windows.Forms.CheckedListBox checkedListBoxLikedPages;
        private System.Windows.Forms.CheckedListBox checkedListBoxEvents;
        private System.Windows.Forms.ComboBox comboBoxMinRange;
        private System.Windows.Forms.ComboBox comboBoxMaxRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}