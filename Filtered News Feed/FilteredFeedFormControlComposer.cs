namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of Composer 1 in Builder pattern 
    /// </summary>
    public class FilteredFeedFormControlComposer
    {
        public void Build(IFilteredFeedFormControlBuilder i_Builder, FilteredNewsFeedForm i_Form)
        {
            i_Builder.Build(i_Form);
            i_Builder.SetSettings();
        }        
    }
}
