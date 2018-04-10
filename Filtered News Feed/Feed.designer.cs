using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public partial class Feed : FilteredFeedFormControl
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
        
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonBackFeed = new System.Windows.Forms.Button();
            this.ButtonFriendRemove = new System.Windows.Forms.Button();
            this.labelFriends1 = new System.Windows.Forms.Label();
            this.ButtonNextPhotoFeed = new System.Windows.Forms.Button();
            this.labelPhotosFeed = new System.Windows.Forms.Label();
            this.labelCheckinsFeed = new System.Windows.Forms.Label();
            this.labelPagesFeed = new System.Windows.Forms.Label();
            this.labelEventsFeed = new System.Windows.Forms.Label();
            this.labelPostsFeed = new System.Windows.Forms.Label();
            this.PictureBoxPhotosFeed = new System.Windows.Forms.PictureBox();
            this.ListBoxCheckinsFeed = new System.Windows.Forms.ListBox();
            this.ListBoxPagesFeed = new System.Windows.Forms.ListBox();
            this.ListBoxEventsFeed = new System.Windows.Forms.ListBox();
            this.ListBoxPostsFeed = new System.Windows.Forms.ListBox();
            this.ListBoxFriendsFeed = new System.Windows.Forms.ListBox();
            this.PictureBoxFriendFeed = new System.Windows.Forms.PictureBox();
            this.labeldeleteFriendFeed = new System.Windows.Forms.Label();
            this.labelViewPhotoFeed = new System.Windows.Forms.Label();
            this.labelViewEventFeed = new System.Windows.Forms.Label();
            this.labelBirthdaysFeed = new System.Windows.Forms.Label();
            this.ListBoxBirthdaysFeed = new System.Windows.Forms.ListBox();
            this.ButtonCreateBirthdayFileFeed = new System.Windows.Forms.Button();
            this.ButtonSendMailFeed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhotosFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriendFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackFeed
            // 
            this.ButtonBackFeed.Location = new System.Drawing.Point(984, 20);
            this.ButtonBackFeed.Name = "buttonBackFeed";
            this.ButtonBackFeed.Size = new System.Drawing.Size(75, 31);
            this.ButtonBackFeed.TabIndex = 90;
            this.ButtonBackFeed.Text = "Back";
            this.ButtonBackFeed.UseVisualStyleBackColor = true;
            this.ButtonBackFeed.Click += new System.EventHandler(this.backButton_Click);
            // 
            // buttonFriendRemove
            // 
            this.ButtonFriendRemove.Enabled = false;
            this.ButtonFriendRemove.Location = new System.Drawing.Point(126, 465);
            this.ButtonFriendRemove.Name = "buttonFriendRemove";
            this.ButtonFriendRemove.Size = new System.Drawing.Size(40, 31);
            this.ButtonFriendRemove.TabIndex = 89;
            this.ButtonFriendRemove.Text = "X";
            this.ButtonFriendRemove.UseVisualStyleBackColor = true;
            this.ButtonFriendRemove.Click += new System.EventHandler(this.buttonFriendRemove_Click);
            // 
            // labelFriends1
            // 
            this.labelFriends1.AutoSize = true;
            this.labelFriends1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFriends1.Location = new System.Drawing.Point(-102, 180);
            this.labelFriends1.Name = "labelFriends1";
            this.labelFriends1.Size = new System.Drawing.Size(107, 20);
            this.labelFriends1.TabIndex = 88;
            this.labelFriends1.Text = "Feed Friends:";
            // 
            // buttonNextPhotoFeed
            // 
            this.ButtonNextPhotoFeed.Location = new System.Drawing.Point(333, 32);
            this.ButtonNextPhotoFeed.Name = "buttonNextPhotoFeed";
            this.ButtonNextPhotoFeed.Size = new System.Drawing.Size(75, 48);
            this.ButtonNextPhotoFeed.TabIndex = 87;
            this.ButtonNextPhotoFeed.Text = ">>";
            this.ButtonNextPhotoFeed.UseVisualStyleBackColor = true;
            this.ButtonNextPhotoFeed.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelPhotosFeed
            // 
            this.labelPhotosFeed.AutoSize = true;
            this.labelPhotosFeed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPhotosFeed.Location = new System.Drawing.Point(315, 9);
            this.labelPhotosFeed.Name = "labelPhotosFeed";
            this.labelPhotosFeed.Size = new System.Drawing.Size(119, 20);
            this.labelPhotosFeed.TabIndex = 86;
            this.labelPhotosFeed.Text = "Recent Photos:";
            // 
            // labelCheckinsFeed
            // 
            this.labelCheckinsFeed.AutoSize = true;
            this.labelCheckinsFeed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCheckinsFeed.Location = new System.Drawing.Point(747, 355);
            this.labelCheckinsFeed.Name = "labelCheckinsFeed";
            this.labelCheckinsFeed.Size = new System.Drawing.Size(134, 20);
            this.labelCheckinsFeed.TabIndex = 85;
            this.labelCheckinsFeed.Text = "Recent Checkins:";
            // 
            // labelPagesFeed
            // 
            this.labelPagesFeed.AutoSize = true;
            this.labelPagesFeed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPagesFeed.Location = new System.Drawing.Point(747, 202);
            this.labelPagesFeed.Name = "labelPagesFeed";
            this.labelPagesFeed.Size = new System.Drawing.Size(104, 20);
            this.labelPagesFeed.TabIndex = 84;
            this.labelPagesFeed.Text = "Liked Pages: ";
            // 
            // labelEventsFeed
            // 
            this.labelEventsFeed.AutoSize = true;
            this.labelEventsFeed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEventsFeed.Location = new System.Drawing.Point(747, 32);
            this.labelEventsFeed.Name = "labelEventsFeed";
            this.labelEventsFeed.Size = new System.Drawing.Size(117, 20);
            this.labelEventsFeed.TabIndex = 83;
            this.labelEventsFeed.Text = "Future Events: ";
            // 
            // labelPostsFeed
            // 
            this.labelPostsFeed.AutoSize = true;
            this.labelPostsFeed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPostsFeed.Location = new System.Drawing.Point(328, 125);
            this.labelPostsFeed.Name = "labelPostsFeed";
            this.labelPostsFeed.Size = new System.Drawing.Size(109, 20);
            this.labelPostsFeed.TabIndex = 82;
            this.labelPostsFeed.Text = "Recent Posts:";
            // 
            // pictureBoxPhotosFeed
            // 
            this.PictureBoxPhotosFeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxPhotosFeed.Location = new System.Drawing.Point(465, 12);
            this.PictureBoxPhotosFeed.Name = "pictureBoxPhotosFeed";
            this.PictureBoxPhotosFeed.Size = new System.Drawing.Size(176, 130);
            this.PictureBoxPhotosFeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPhotosFeed.TabIndex = 81;
            this.PictureBoxPhotosFeed.TabStop = false;
            // 
            // listBoxCheckinsFeed
            // 
            this.ListBoxCheckinsFeed.FormattingEnabled = true;
            this.ListBoxCheckinsFeed.ItemHeight = 20;
            this.ListBoxCheckinsFeed.Location = new System.Drawing.Point(752, 380);
            this.ListBoxCheckinsFeed.Name = "listBoxCheckinsFeed";
            this.ListBoxCheckinsFeed.Size = new System.Drawing.Size(308, 124);
            this.ListBoxCheckinsFeed.TabIndex = 80;
            // 
            // listBoxPagesFeed
            // 
            this.ListBoxPagesFeed.FormattingEnabled = true;
            this.ListBoxPagesFeed.ItemHeight = 20;
            this.ListBoxPagesFeed.Location = new System.Drawing.Point(752, 226);
            this.ListBoxPagesFeed.Name = "listBoxPagesFeed";
            this.ListBoxPagesFeed.Size = new System.Drawing.Size(308, 124);
            this.ListBoxPagesFeed.TabIndex = 79;
            // 
            // listBoxEventsFeed
            // 
            this.ListBoxEventsFeed.FormattingEnabled = true;
            this.ListBoxEventsFeed.ItemHeight = 20;
            this.ListBoxEventsFeed.Location = new System.Drawing.Point(752, 55);
            this.ListBoxEventsFeed.Name = "listBoxEventsFeed";
            this.ListBoxEventsFeed.Size = new System.Drawing.Size(308, 124);
            this.ListBoxEventsFeed.TabIndex = 78;
            this.ListBoxEventsFeed.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // listBoxPostsFeed
            // 
            this.ListBoxPostsFeed.FormattingEnabled = true;
            this.ListBoxPostsFeed.ItemHeight = 20;
            this.ListBoxPostsFeed.Location = new System.Drawing.Point(333, 149);
            this.ListBoxPostsFeed.Name = "listBoxPostsFeed";
            this.ListBoxPostsFeed.Size = new System.Drawing.Size(392, 344);
            this.ListBoxPostsFeed.TabIndex = 77;
            // 
            // listBoxFriendsFeed
            // 
            this.ListBoxFriendsFeed.FormattingEnabled = true;
            this.ListBoxFriendsFeed.ItemHeight = 20;
            this.ListBoxFriendsFeed.Location = new System.Drawing.Point(15, 149);
            this.ListBoxFriendsFeed.Name = "listBoxFriendsFeed";
            this.ListBoxFriendsFeed.Size = new System.Drawing.Size(150, 344);
            this.ListBoxFriendsFeed.TabIndex = 76;
            this.ListBoxFriendsFeed.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxFriendFeed
            // 
            this.PictureBoxFriendFeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxFriendFeed.Location = new System.Drawing.Point(15, 12);
            this.PictureBoxFriendFeed.Name = "pictureBoxFriendFeed";
            this.PictureBoxFriendFeed.Size = new System.Drawing.Size(151, 122);
            this.PictureBoxFriendFeed.TabIndex = 75;
            this.PictureBoxFriendFeed.TabStop = false;
            // 
            // labeldeleteFriendFeed
            // 
            this.labeldeleteFriendFeed.AutoSize = true;
            this.labeldeleteFriendFeed.Location = new System.Drawing.Point(-4, 497);
            this.labeldeleteFriendFeed.Name = "labeldeleteFriendFeed";
            this.labeldeleteFriendFeed.Size = new System.Drawing.Size(197, 20);
            this.labeldeleteFriendFeed.TabIndex = 91;
            this.labeldeleteFriendFeed.Text = "(Delete Friend From Feed)";
            // 
            // labelViewPhotoFeed
            // 
            this.labelViewPhotoFeed.AutoSize = true;
            this.labelViewPhotoFeed.Location = new System.Drawing.Point(298, 83);
            this.labelViewPhotoFeed.Name = "labelViewPhotoFeed";
            this.labelViewPhotoFeed.Size = new System.Drawing.Size(154, 20);
            this.labelViewPhotoFeed.TabIndex = 92;
            this.labelViewPhotoFeed.Text = "(click to view photos)";
            // 
            // labelViewEventFeed
            // 
            this.labelViewEventFeed.AutoSize = true;
            this.labelViewEventFeed.Location = new System.Drawing.Point(722, 12);
            this.labelViewEventFeed.Name = "labelViewEventFeed";
            this.labelViewEventFeed.Size = new System.Drawing.Size(247, 20);
            this.labelViewEventFeed.TabIndex = 93;
            this.labelViewEventFeed.Text = "(click on Event to view attendings)";
            // 
            // labelBirthdaysFeed
            // 
            this.labelBirthdaysFeed.AutoSize = true;
            this.labelBirthdaysFeed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBirthdaysFeed.Location = new System.Drawing.Point(178, 125);
            this.labelBirthdaysFeed.Name = "labelBirthdaysFeed";
            this.labelBirthdaysFeed.Size = new System.Drawing.Size(136, 20);
            this.labelBirthdaysFeed.TabIndex = 94;
            this.labelBirthdaysFeed.Text = "Friends Birthdays:";
            // 
            // listBoxBirthdaysFeed
            // 
            this.ListBoxBirthdaysFeed.FormattingEnabled = true;
            this.ListBoxBirthdaysFeed.ItemHeight = 20;
            this.ListBoxBirthdaysFeed.Location = new System.Drawing.Point(182, 151);
            this.ListBoxBirthdaysFeed.Name = "listBoxBirthdaysFeed";
            this.ListBoxBirthdaysFeed.Size = new System.Drawing.Size(133, 344);
            this.ListBoxBirthdaysFeed.TabIndex = 95;
            // 
            // buttonCreateBirthdayFileFeed
            // 
            this.ButtonCreateBirthdayFileFeed.Location = new System.Drawing.Point(183, 465);
            this.ButtonCreateBirthdayFileFeed.Name = "buttonCreateBirthdayFileFeed";
            this.ButtonCreateBirthdayFileFeed.Size = new System.Drawing.Size(135, 32);
            this.ButtonCreateBirthdayFileFeed.TabIndex = 96;
            this.ButtonCreateBirthdayFileFeed.Text = "Save To File";
            this.ButtonCreateBirthdayFileFeed.UseVisualStyleBackColor = true;
            this.ButtonCreateBirthdayFileFeed.Click += new System.EventHandler(this.buttonCreateBirthdayFileFeed_Click);
            // 
            // buttonSendMailFeed
            // 
            this.ButtonSendMailFeed.Location = new System.Drawing.Point(849, 180);
            this.ButtonSendMailFeed.Name = "buttonSendMailFeed";
            this.ButtonSendMailFeed.Size = new System.Drawing.Size(213, 29);
            this.ButtonSendMailFeed.TabIndex = 97;
            this.ButtonSendMailFeed.Text = "Send Notification Mail";
            this.ButtonSendMailFeed.UseVisualStyleBackColor = true;
            this.ButtonSendMailFeed.Click += new System.EventHandler(this.buttonSendMailFeed_Click);
            // 
            // Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.ButtonSendMailFeed);
            this.Controls.Add(this.ButtonCreateBirthdayFileFeed);
            this.Controls.Add(this.ListBoxBirthdaysFeed);
            this.Controls.Add(this.labelBirthdaysFeed);
            this.Controls.Add(this.labelViewEventFeed);
            this.Controls.Add(this.labelViewPhotoFeed);
            this.Controls.Add(this.labeldeleteFriendFeed);
            this.Controls.Add(this.ButtonBackFeed);
            this.Controls.Add(this.ButtonFriendRemove);
            this.Controls.Add(this.labelFriends1);
            this.Controls.Add(this.ButtonNextPhotoFeed);
            this.Controls.Add(this.labelPhotosFeed);
            this.Controls.Add(this.labelCheckinsFeed);
            this.Controls.Add(this.labelPagesFeed);
            this.Controls.Add(this.labelEventsFeed);
            this.Controls.Add(this.labelPostsFeed);
            this.Controls.Add(this.PictureBoxPhotosFeed);
            this.Controls.Add(this.ListBoxCheckinsFeed);
            this.Controls.Add(this.ListBoxPagesFeed);
            this.Controls.Add(this.ListBoxEventsFeed);
            this.Controls.Add(this.ListBoxPostsFeed);
            this.Controls.Add(this.ListBoxFriendsFeed);
            this.Controls.Add(this.PictureBoxFriendFeed);
            this.Name = "Feed";
            this.Size = new System.Drawing.Size(1072, 517);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhotosFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriendFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFriends1;
        private System.Windows.Forms.Label labelPhotosFeed;
        private System.Windows.Forms.Label labelCheckinsFeed;
        private System.Windows.Forms.Label labelPagesFeed;
        private System.Windows.Forms.Label labelEventsFeed;
        private System.Windows.Forms.Label labelPostsFeed;
        public Button ButtonBackFeed;
        public Button ButtonFriendRemove;
        public Button ButtonNextPhotoFeed;
        public PictureBox PictureBoxPhotosFeed;
        public ListBox ListBoxCheckinsFeed;
        public ListBox ListBoxPagesFeed;
        public ListBox ListBoxEventsFeed;
        public ListBox ListBoxPostsFeed;
        public ListBox ListBoxFriendsFeed;
        public PictureBox PictureBoxFriendFeed;
        private Label labeldeleteFriendFeed;
        private Label labelViewPhotoFeed;
        private Label labelViewEventFeed;
        private Label labelBirthdaysFeed;
        public ListBox ListBoxBirthdaysFeed;
        public Button ButtonCreateBirthdayFileFeed;
        public Button ButtonSendMailFeed;
    }
}
