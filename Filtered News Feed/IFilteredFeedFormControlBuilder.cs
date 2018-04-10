namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of abstract Builder in Builder pattern 
    /// </summary>
    public interface IFilteredFeedFormControlBuilder
    {
        void Build(FilteredNewsFeedForm i_Form);

        void SetSettings();  

        FilteredFeedFormControl Control { get; }
    }
}