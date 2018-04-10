namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    internal partial class ZodiacMatchingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZodiacMatchingForm));
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fetchLikedPagesButton = new System.Windows.Forms.Button();
            this.selectPageButton = new System.Windows.Forms.Button();
            this.listBoxCommonFriends = new System.Windows.Forms.ListBox();
            this.comboBoxZodiacSigns = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxRelationShipStatus = new System.Windows.Forms.ComboBox();
            this.fetchLikedPagesLabel = new System.Windows.Forms.Label();
            this.selectPageLabel = new System.Windows.Forms.Label();
            this.applyFiltersButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetFiltersButton = new System.Windows.Forms.Button();
            this.filterFriendsLaber = new System.Windows.Forms.Label();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.loveCompatibilityButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFriendPicture = new System.Windows.Forms.Label();
            this.labelSelectedPage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.sortAscLexicography = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortDescLexicography = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserProfile.BackgroundImage")));
            this.pictureBoxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(219, 18);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(98, 90);
            this.pictureBoxUserProfile.TabIndex = 2;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userNameTextBox.Enabled = false;
            this.userNameTextBox.Location = new System.Drawing.Point(12, 88);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.userNameTextBox.TabIndex = 3;
            this.userNameTextBox.Text = "User Name";
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(12, 155);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(374, 173);
            this.listBoxLikedPages.TabIndex = 4;
            this.listBoxLikedPages.ValueMember = "AccessToken";
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // fetchLikedPagesButton
            // 
            this.fetchLikedPagesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fetchLikedPagesButton.BackgroundImage")));
            this.fetchLikedPagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fetchLikedPagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchLikedPagesButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fetchLikedPagesButton.Location = new System.Drawing.Point(12, 114);
            this.fetchLikedPagesButton.Name = "fetchLikedPagesButton";
            this.fetchLikedPagesButton.Size = new System.Drawing.Size(106, 41);
            this.fetchLikedPagesButton.TabIndex = 5;
            this.fetchLikedPagesButton.Text = "Fetch Liked Pages";
            this.fetchLikedPagesButton.UseVisualStyleBackColor = true;
            this.fetchLikedPagesButton.Click += new System.EventHandler(this.fetchLikedPages_Click);
            // 
            // selectPageButton
            // 
            this.selectPageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectPageButton.BackgroundImage")));
            this.selectPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectPageButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.selectPageButton.Location = new System.Drawing.Point(11, 333);
            this.selectPageButton.Name = "selectPageButton";
            this.selectPageButton.Size = new System.Drawing.Size(107, 32);
            this.selectPageButton.TabIndex = 6;
            this.selectPageButton.Text = "Select Page";
            this.selectPageButton.UseVisualStyleBackColor = true;
            this.selectPageButton.Click += new System.EventHandler(this.selectPageButton_Click);
            // 
            // listBoxCommonFriends
            // 
            this.listBoxCommonFriends.FormattingEnabled = true;
            this.listBoxCommonFriends.Location = new System.Drawing.Point(12, 363);
            this.listBoxCommonFriends.Name = "listBoxCommonFriends";
            this.listBoxCommonFriends.Size = new System.Drawing.Size(132, 147);
            this.listBoxCommonFriends.TabIndex = 7;
            this.listBoxCommonFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxCommonFriends_SelectedIndexChanged);
            // 
            // comboBoxZodiacSigns
            // 
            this.comboBoxZodiacSigns.Enabled = false;
            this.comboBoxZodiacSigns.FormattingEnabled = true;
            this.comboBoxZodiacSigns.Location = new System.Drawing.Point(7, 77);
            this.comboBoxZodiacSigns.Name = "comboBoxZodiacSigns";
            this.comboBoxZodiacSigns.Size = new System.Drawing.Size(121, 21);
            this.comboBoxZodiacSigns.TabIndex = 10;
            this.comboBoxZodiacSigns.Text = "Zodiac Signs";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxGender.Location = new System.Drawing.Point(8, 39);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 12;
            this.comboBoxGender.Text = "Gender";
            // 
            // comboBoxRelationShipStatus
            // 
            this.comboBoxRelationShipStatus.FormattingEnabled = true;
            this.comboBoxRelationShipStatus.Location = new System.Drawing.Point(7, 113);
            this.comboBoxRelationShipStatus.Name = "comboBoxRelationShipStatus";
            this.comboBoxRelationShipStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRelationShipStatus.TabIndex = 13;
            this.comboBoxRelationShipStatus.Text = "Relationship Status";
            // 
            // fetchLikedPagesLabel
            // 
            this.fetchLikedPagesLabel.AutoSize = true;
            this.fetchLikedPagesLabel.Location = new System.Drawing.Point(121, 131);
            this.fetchLikedPagesLabel.Name = "fetchLikedPagesLabel";
            this.fetchLikedPagesLabel.Size = new System.Drawing.Size(335, 13);
            this.fetchLikedPagesLabel.TabIndex = 20;
            this.fetchLikedPagesLabel.Text = "(and choose one of them for showing friends who also liked this page)";
            // 
            // selectPageLabel
            // 
            this.selectPageLabel.AutoSize = true;
            this.selectPageLabel.Location = new System.Drawing.Point(108, 339);
            this.selectPageLabel.Name = "selectPageLabel";
            this.selectPageLabel.Size = new System.Drawing.Size(0, 13);
            this.selectPageLabel.TabIndex = 21;
            // 
            // applyFiltersButton
            // 
            this.applyFiltersButton.BackColor = System.Drawing.SystemColors.Control;
            this.applyFiltersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.applyFiltersButton.Location = new System.Drawing.Point(134, 90);
            this.applyFiltersButton.Name = "applyFiltersButton";
            this.applyFiltersButton.Size = new System.Drawing.Size(55, 44);
            this.applyFiltersButton.TabIndex = 22;
            this.applyFiltersButton.Text = "Apply Filters";
            this.applyFiltersButton.UseVisualStyleBackColor = false;
            this.applyFiltersButton.Click += new System.EventHandler(this.applyFiltersButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.resetFiltersButton);
            this.panel1.Controls.Add(this.filterFriendsLaber);
            this.panel1.Controls.Add(this.applyFiltersButton);
            this.panel1.Controls.Add(this.comboBoxRelationShipStatus);
            this.panel1.Controls.Add(this.comboBoxZodiacSigns);
            this.panel1.Controls.Add(this.comboBoxGender);
            this.panel1.Location = new System.Drawing.Point(158, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 147);
            this.panel1.TabIndex = 24;
            // 
            // resetFiltersButton
            // 
            this.resetFiltersButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetFiltersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetFiltersButton.Location = new System.Drawing.Point(135, 42);
            this.resetFiltersButton.Name = "resetFiltersButton";
            this.resetFiltersButton.Size = new System.Drawing.Size(53, 34);
            this.resetFiltersButton.TabIndex = 25;
            this.resetFiltersButton.Text = "Reset Filters";
            this.resetFiltersButton.UseVisualStyleBackColor = false;
            this.resetFiltersButton.Click += new System.EventHandler(this.resetFiltersButton_Click);
            // 
            // filterFriendsLaber
            // 
            this.filterFriendsLaber.AutoSize = true;
            this.filterFriendsLaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFriendsLaber.Location = new System.Drawing.Point(38, 9);
            this.filterFriendsLaber.Name = "filterFriendsLaber";
            this.filterFriendsLaber.Size = new System.Drawing.Size(115, 20);
            this.filterFriendsLaber.TabIndex = 25;
            this.filterFriendsLaber.Text = "Filter Friends";
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFriend.BackgroundImage")));
            this.pictureBoxFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFriend.Location = new System.Drawing.Point(381, 410);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(101, 94);
            this.pictureBoxFriend.TabIndex = 25;
            this.pictureBoxFriend.TabStop = false;
            // 
            // loveCompatibilityButton
            // 
            this.loveCompatibilityButton.BackColor = System.Drawing.SystemColors.Control;
            this.loveCompatibilityButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loveCompatibilityButton.BackgroundImage")));
            this.loveCompatibilityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loveCompatibilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loveCompatibilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loveCompatibilityButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loveCompatibilityButton.Location = new System.Drawing.Point(161, 516);
            this.loveCompatibilityButton.Name = "loveCompatibilityButton";
            this.loveCompatibilityButton.Size = new System.Drawing.Size(189, 85);
            this.loveCompatibilityButton.TabIndex = 26;
            this.loveCompatibilityButton.Text = "Check Love Compatibility";
            this.loveCompatibilityButton.UseVisualStyleBackColor = false;
            this.loveCompatibilityButton.Click += new System.EventHandler(this.lovecompatibilityButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 51);
            this.panel2.TabIndex = 27;
            // 
            // labelFriendPicture
            // 
            this.labelFriendPicture.AutoSize = true;
            this.labelFriendPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendPicture.Location = new System.Drawing.Point(380, 374);
            this.labelFriendPicture.Name = "labelFriendPicture";
            this.labelFriendPicture.Size = new System.Drawing.Size(104, 16);
            this.labelFriendPicture.TabIndex = 28;
            this.labelFriendPicture.Text = "Friend Picture";
            // 
            // labelSelectedPage
            // 
            this.labelSelectedPage.AutoSize = true;
            this.labelSelectedPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedPage.Location = new System.Drawing.Point(396, 155);
            this.labelSelectedPage.Name = "labelSelectedPage";
            this.labelSelectedPage.Size = new System.Drawing.Size(111, 16);
            this.labelSelectedPage.TabIndex = 29;
            this.labelSelectedPage.Text = "Selected Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(383, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 126);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.pictureBoxPage.Location = new System.Drawing.Point(399, 174);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(100, 91);
            this.pictureBoxPage.TabIndex = 31;
            this.pictureBoxPage.TabStop = false;
            // 
            // sortAscLexicography
            // 
            this.sortAscLexicography.Location = new System.Drawing.Point(392, 275);
            this.sortAscLexicography.Name = "sortAscLexicography";
            this.sortAscLexicography.Size = new System.Drawing.Size(131, 23);
            this.sortAscLexicography.TabIndex = 32;
            this.sortAscLexicography.Text = "Sort Asc Lexicography";
            this.sortAscLexicography.UseVisualStyleBackColor = true;
            this.sortAscLexicography.Click += new System.EventHandler(this.sortAscLexicography_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sortDescLexicography
            // 
            this.sortDescLexicography.Location = new System.Drawing.Point(392, 304);
            this.sortDescLexicography.Name = "sortDescLexicography";
            this.sortDescLexicography.Size = new System.Drawing.Size(131, 23);
            this.sortDescLexicography.TabIndex = 35;
            this.sortDescLexicography.Text = "Sort Desc Lexicography";
            this.sortDescLexicography.UseVisualStyleBackColor = true;
            this.sortDescLexicography.Click += new System.EventHandler(this.sortDescLexicography_Click);
            // 
            // ZodiacMatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(529, 621);
            this.Controls.Add(this.sortDescLexicography);
            this.Controls.Add(this.sortAscLexicography);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSelectedPage);
            this.Controls.Add(this.labelFriendPicture);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loveCompatibilityButton);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectPageLabel);
            this.Controls.Add(this.fetchLikedPagesLabel);
            this.Controls.Add(this.listBoxCommonFriends);
            this.Controls.Add(this.selectPageButton);
            this.Controls.Add(this.fetchLikedPagesButton);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ZodiacMatchingForm";
            this.Text = "Love compatibility Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button fetchLikedPagesButton;
        private System.Windows.Forms.Button selectPageButton;
        private System.Windows.Forms.ListBox listBoxCommonFriends;
        private System.Windows.Forms.ComboBox comboBoxZodiacSigns;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxRelationShipStatus;
        private System.Windows.Forms.Label fetchLikedPagesLabel;
        private System.Windows.Forms.Label selectPageLabel;
        private System.Windows.Forms.Button applyFiltersButton;
        private System.Windows.Forms.Label filterFriendsLaber;
        private System.Windows.Forms.Button resetFiltersButton;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Button loveCompatibilityButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFriendPicture;
        private System.Windows.Forms.Label labelSelectedPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.Button sortAscLexicography;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button sortDescLexicography;
    }
}