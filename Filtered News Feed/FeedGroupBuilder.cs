namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of concrete Builder 2 in Builder pattern 
    /// </summary>
    public class FeedGroupBuilder : IFilteredFeedFormControlBuilder
    {
        private FeedGroup m_FeedGroup;

        public void Build(FilteredNewsFeedForm i_Form)
        {
            this.m_FeedGroup = new FeedGroup(i_Form);
        }

        public void SetSettings()
        {
            this.m_FeedGroup.AutoSize = true;
            this.m_FeedGroup.BringToFront();
        }

        public FilteredFeedFormControl Control
        {
            get { return this.m_FeedGroup; }
        }
    }
}
