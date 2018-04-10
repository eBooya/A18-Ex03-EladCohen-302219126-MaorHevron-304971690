namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public partial class FilteredNewsFeedForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxFeedGroups = new System.Windows.Forms.GroupBox();
            this.groupBoxAttachButtons = new System.Windows.Forms.GroupBox();
            this.buttonAddFeedGroup = new System.Windows.Forms.Button();
            this.labelFetchFriends = new System.Windows.Forms.Label();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.ListBoxFriends = new System.Windows.Forms.ListBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
            this.TabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.TabPage1.AutoScroll = true;
            this.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TabPage1.Controls.Add(this.groupBoxFeedGroups);
            this.TabPage1.Controls.Add(this.groupBoxAttachButtons);
            this.TabPage1.Controls.Add(this.buttonAddFeedGroup);
            this.TabPage1.Controls.Add(this.labelFetchFriends);
            this.TabPage1.Controls.Add(this.buttonFetchFriends);
            this.TabPage1.Controls.Add(this.label2);
            this.TabPage1.Controls.Add(this.label1);
            this.TabPage1.Controls.Add(this.PictureBoxFriend);
            this.TabPage1.Controls.Add(this.ListBoxFriends);
            this.TabPage1.Controls.Add(this.labelHello);
            this.TabPage1.Controls.Add(this.pictureBoxUser);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.TabPage1.Name = "tabPage1";
            this.TabPage1.Size = new System.Drawing.Size(1160, 566);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Homepage";
            // 
            // groupBoxFeedGroups
            // 
            this.groupBoxFeedGroups.Location = new System.Drawing.Point(505, 12);
            this.groupBoxFeedGroups.Name = "groupBoxFeedGroups";
            this.groupBoxFeedGroups.Size = new System.Drawing.Size(626, 500);
            this.groupBoxFeedGroups.TabIndex = 87;
            this.groupBoxFeedGroups.TabStop = false;
            // 
            // groupBoxAttachButtons
            // 
            this.groupBoxAttachButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxAttachButtons.Location = new System.Drawing.Point(291, 421);
            this.groupBoxAttachButtons.Name = "groupBoxAttachButtons";
            this.groupBoxAttachButtons.Size = new System.Drawing.Size(190, 91);
            this.groupBoxAttachButtons.TabIndex = 86;
            this.groupBoxAttachButtons.TabStop = false;
            // 
            // buttonAddFeedGroup
            // 
            this.buttonAddFeedGroup.Location = new System.Drawing.Point(290, 378);
            this.buttonAddFeedGroup.Name = "buttonAddFeedGroup";
            this.buttonAddFeedGroup.Size = new System.Drawing.Size(191, 43);
            this.buttonAddFeedGroup.TabIndex = 81;
            this.buttonAddFeedGroup.Text = "Add Feed Group";
            this.buttonAddFeedGroup.UseVisualStyleBackColor = true;
            this.buttonAddFeedGroup.Click += new System.EventHandler(this.buttonAddFeedGroup_Click);
            // 
            // labelFetchFriends
            // 
            this.labelFetchFriends.AutoSize = true;
            this.labelFetchFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFetchFriends.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFetchFriends.Location = new System.Drawing.Point(290, 12);
            this.labelFetchFriends.Name = "labelFetchFriends";
            this.labelFetchFriends.Size = new System.Drawing.Size(137, 25);
            this.labelFetchFriends.TabIndex = 78;
            this.labelFetchFriends.Text = "Fetch Friends:";
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchFriends.Location = new System.Drawing.Point(212, 18);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(75, 25);
            this.buttonFetchFriends.TabIndex = 77;
            this.buttonFetchFriends.Text = ">>";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 40);
            this.label2.TabIndex = 76;
            this.label2.Text = "(click on friend to view picture, select friend\r\nand click on number to attach to" +
    " group)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 40);
            this.label1.TabIndex = 75;
            this.label1.Text = "(set feed name in text box, click on \'Feed\' to create your Filtered Feed, \r\n     " +
    "                 click on \'X\' to remove friend from group)";
            // 
            // pictureBoxFriend
            // 
            this.PictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxFriend.Location = new System.Drawing.Point(151, 335);
            this.PictureBoxFriend.Name = "pictureBoxFriend";
            this.PictureBoxFriend.Size = new System.Drawing.Size(135, 149);
            this.PictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxFriend.TabIndex = 71;
            this.PictureBoxFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.ListBoxFriends.Enabled = false;
            this.ListBoxFriends.FormattingEnabled = true;
            this.ListBoxFriends.ItemHeight = 20;
            this.ListBoxFriends.Location = new System.Drawing.Point(214, 49);
            this.ListBoxFriends.Name = "listBoxFriends";
            this.ListBoxFriends.Size = new System.Drawing.Size(266, 324);
            this.ListBoxFriends.TabIndex = 47;
            this.ListBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHello.Location = new System.Drawing.Point(36, 215);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(56, 25);
            this.labelHello.TabIndex = 45;
            this.labelHello.Text = "Hello";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(9, 49);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(198, 165);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 44;
            this.pictureBoxUser.TabStop = false;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.friendListBindingSource;
            // 
            // friendListBindingSource
            // 
            this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
            // 
            // tabControl
            // 
            this.TabControl.Controls.Add(this.TabPage1);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, -3);
            this.TabControl.Name = "tabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1168, 599);
            this.TabControl.TabIndex = 0;
            // 
            // FilteredNewsFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 596);
            this.Controls.Add(this.TabControl);
            this.Name = "FilteredNewsFeedForm";
            this.Text = "My Filtered News Feed";
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
            this.TabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.Button buttonAddFeedGroup;
        private System.Windows.Forms.Label labelFetchFriends;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox ListBoxFriends;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        public System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource friendListBindingSource;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.GroupBox groupBoxAttachButtons;
        public System.Windows.Forms.PictureBox PictureBoxFriend;
        private System.Windows.Forms.GroupBox groupBoxFeedGroups;
    }
}