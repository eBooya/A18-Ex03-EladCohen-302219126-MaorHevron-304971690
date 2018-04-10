using System;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public partial class FeedGroup : FilteredFeedFormControl
    {
        /// <summary>
        /// plays the role of concrete complex product 2 in Builder pattern 
        /// </summary>
        public FilteredFeedFormControlComposer m_FeedComposer = new FilteredFeedFormControlComposer();
        public IFilteredFeedFormControlBuilder m_FeedBuilder = new FeedBuilder();
        // c'tor
        public FeedGroup(FilteredNewsFeedForm i_Form) : base(i_Form)
        {
            this.InitializeComponent();
        }

        private void listBoxFeedGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ButtonRemoveFeedGroup.Enabled = true;
        }

        private void buttonBuildFeedFeedGroup_Click(object sender, EventArgs e)
        {
            if (TextBoxFeedGroup.Text == string.Empty)
            {
                MessageBox.Show("First Set Feed Name");
            }
            else
            {
                new Thread(createFeed).Start();
            }
        }

        private void createFeed()
        {
            this.Invoke(new Action(() => ButtonBuildFeedFeedGroup.Enabled = false));
            if (ListBoxFeedGroup.Items.Count > 0)
            {
                TabPage feedTab = new TabPage();
                feedTab.Text = this.TextBoxFeedGroup.Text + " Feed";
                this.m_Form.Invoke(new Action(() => this.m_Form.TabControl.TabPages.Add(feedTab)));
                FilteredNewsFeedForm.s_FeedGroupsCount = this.m_Number;// TODO:
                this.m_FeedComposer.Build(this.m_FeedBuilder, this.m_Form);
                Feed feed = this.m_FeedBuilder.Control as Feed;
                feed.Dock = DockStyle.Fill;
                feedTab.Invoke(new Action(() => feedTab.Controls.Add(feed)));
                this.m_Form.Invoke(new Action(() => this.m_Form.TabControl.SelectedTab = feedTab));
            }           
        }

        private void buttonRemoveFeedGroup_Click(object sender, EventArgs e)
        {
            if (this.ListBoxFeedGroup.SelectedItems.Count == 1)
            {
                User selectedFriend = this.ListBoxFeedGroup.SelectedItem as User;
                if (this.m_Form.ListBoxFriends.Items.Contains(selectedFriend) == false)
                {
                    this.m_Form.ListBoxFriends.Items.Add(selectedFriend);
                }

                this.ListBoxFeedGroup.Items.Remove(selectedFriend);

                if (this.ListBoxFeedGroup.Items.Count > 0)
                {
                    this.m_FeedBuilder.SetSettings();
                }
                else
                {
                    this.TextBoxFeedGroup.Text = string.Empty;
                    this.ButtonBuildFeedFeedGroup.Enabled = false;
                    this.ButtonRemoveFeedGroup.Enabled = false;
                    //// TODO: Remove this Feed from Feeds List and update m_Numbers.
                    if (this.m_Form.TabControl.TabPages.Count > 1)
                    {
                        this.m_Form.TabControl.TabPages.Remove(this.m_Form.TabControl.TabPages[this.m_Number]);//m_Form.TabControl.TabPages.Count - 1]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pick a friend to remove");
            }
        }
    }
}
