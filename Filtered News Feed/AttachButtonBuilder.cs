namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of concrete Builder 1 in Builder pattern 
    /// </summary>
    public class AttachButtonBuilder : IFilteredFeedFormControlBuilder
    {     
        private AttachButton m_AttachButton;

        public void Build(FilteredNewsFeedForm i_Form)
        {
            this.m_AttachButton = new AttachButton(i_Form);
        }

        public void SetSettings()
        {
            this.m_AttachButton.ButtonAttachFriendToFeedGroup.AutoSize = true;
            this.m_AttachButton.ButtonAttachFriendToFeedGroup.Text = FilteredNewsFeedForm.s_FeedGroupsCount.ToString();
            this.m_AttachButton.ButtonAttachFriendToFeedGroup.Width = 40;
            this.m_AttachButton.ButtonAttachFriendToFeedGroup.Height = 30;
            this.m_AttachButton.ButtonAttachFriendToFeedGroup.Enabled = false;
            this.m_AttachButton.BringToFront();
        }

        public FilteredFeedFormControl Control
        {
            get { return this.m_AttachButton; }
        }
    }
}
