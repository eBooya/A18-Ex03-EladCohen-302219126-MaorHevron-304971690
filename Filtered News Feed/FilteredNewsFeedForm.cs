using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public partial class FilteredNewsFeedForm : Form
    {
        /// <summary>
        /// plays the role of Client in Builder pattern
        /// plays the role of the observer in Observer pattern
        /// </summary> 
        private User m_LoggedInUser = null;
        public static int s_FeedGroupsCount = 0;

        public List<AttachButton> AttachButtons { get; set; } = new List<AttachButton>();

        public List<FeedGroup> FeedGroups { get; set; } = new List<FeedGroup>();

        public List<Feed> Feeds { get; set; } = new List<Feed>();        

        // c'tor
        public FilteredNewsFeedForm(User i_LoggedInUser)
        {
            this.InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
            this.fetchInfo();
        }

        private void fetchInfo()
        {
            if (this.m_LoggedInUser != null)
            {
                this.pictureBoxUser.LoadAsync(this.m_LoggedInUser.PictureNormalURL);
                this.labelHello.Text = "Hello " + this.m_LoggedInUser.FirstName + "!";
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.CenterToScreen();
            MessageBox.Show(
                @"To Make A News Feed Showing Only News Of Friends Of Your Choice:
                  1. First, Fetch Friends.
                  2. Then, Click: 'Add Feed Group' To Create A Feed Group. 
                  3. Add/Remove Friends To/From Groups.
                  4. Create Feeds By Clicking The 'Feed' Button.");
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            this.reset();
        }

        private void reset()
        {
            s_FeedGroupsCount = 0;
            this.AttachButtons.Clear();
            this.FeedGroups.Clear();
            this.Feeds.Clear();                     
        }

        private void enableButtons()
        {
            for (int i = 0; i < s_FeedGroupsCount; i++)
            {
                this.AttachButtons[i].ButtonAttachFriendToFeedGroup.Enabled = true;
            }
        }

        private void buttonAddFeedGroup_Click(object sender, EventArgs e)
        {                                   
            this.ListBoxFriends.Enabled = true;
            if (s_FeedGroupsCount < 3)
            {
                s_FeedGroupsCount++;
                //// Attach-Button Creation. Derives from UserControl
                this.createAttachButton();                
                //// Feed-Group Creation. Derives from UserControl as well. Implements Polimorphizm with Attach-Button. 
                this.createFeedGroup();                           
            }
            else
            {
                this.buttonAddFeedGroup.Enabled = false;
                MessageBox.Show("3 Feeds Max!");
            }
            
            if(this.ListBoxFriends.SelectedItems.Count == 1)
            {
                this.enableButtons();
            }
        }

        private void createAttachButton()
        {
            FilteredFeedFormControlComposer attachButtonComposer = new FilteredFeedFormControlComposer();
            IFilteredFeedFormControlBuilder attachButtonBuilder = new AttachButtonBuilder();

            attachButtonComposer.Build(attachButtonBuilder, this);
            AttachButton attachButton = attachButtonBuilder.Control as AttachButton;
            //the form registers as an observer of attachButton by giving a reference to a method:
            attachButton.m_AttachButtonDelegates += this.diasableAttachButtons; 
            attachButton.Dock = DockStyle.Right;
            this.AttachButtons.Add(attachButton);
            this.groupBoxAttachButtons.Controls.Add(attachButton);
        }

        private void createFeedGroup()
        {
            FilteredFeedFormControlComposer feedGroupComposer = new FilteredFeedFormControlComposer();
            IFilteredFeedFormControlBuilder feedGroupBuilder = new FeedGroupBuilder();

            feedGroupComposer.Build(feedGroupBuilder, this);
            FeedGroup feedGroup = feedGroupBuilder.Control as FeedGroup;
            //giving a reference to a method, by a lambda expression, also ivoked by the notifyer attachButton on click:
            this.AttachButtons[feedGroup.m_Number - 1].m_AttachButtonDelegates += (() => this.FeedGroups[feedGroup.m_Number - 1].ButtonBuildFeedFeedGroup.Enabled = true);
            feedGroup.Dock = DockStyle.Right;
            this.FeedGroups.Add(feedGroup);
            this.groupBoxFeedGroups.Controls.Add(feedGroup);
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListBoxFriends.SelectedItems.Count == 1)
            {
                User selectedfriend = this.ListBoxFriends.SelectedItem as User;
                this.PictureBoxFriend.LoadAsync(selectedfriend.PictureNormalURL);
                this.enableButtons();
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            new Thread(this.fetchFriends).Start();
        }

        private void fetchFriends()
        {                      
            this.ListBoxFriends.Invoke(new Action(() => this.ListBoxFriends.Items.Clear()));
            this.ListBoxFriends.DisplayMember = "Name";
            try
            {
                foreach (User friend in this.m_LoggedInUser.Friends)
                {
                    this.ListBoxFriends.Invoke(new Action(() => this.ListBoxFriends.Items.Add(friend)));
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(
@"Error while trying to fetch friends from facebook!
reason: {0}",
ex.Message));
            }
        }

        private void diasableAttachButtons()
        {
            for (int i = 0; i < this.AttachButtons.Count; i++)
            {
                this.AttachButtons[i].ButtonAttachFriendToFeedGroup.Enabled = false;
            }
        }
    }
}
