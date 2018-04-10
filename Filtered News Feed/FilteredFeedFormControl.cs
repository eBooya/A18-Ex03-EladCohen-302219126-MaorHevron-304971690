using System.Windows.Forms;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public abstract class FilteredFeedFormControl : UserControl
    {
        /// <summary>
        /// plays the role of abstract complex product  in Builder pattern 
        /// </summary>
        public FilteredNewsFeedForm m_Form;
        public int m_Number;

        ////c'tor
        public FilteredFeedFormControl(FilteredNewsFeedForm i_Form)
        {
            this.m_Form = i_Form;
            this.m_Number = FilteredNewsFeedForm.s_FeedGroupsCount;
        }
    }
}
