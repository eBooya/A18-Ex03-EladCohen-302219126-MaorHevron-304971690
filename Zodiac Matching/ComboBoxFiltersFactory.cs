using System.Windows.Forms;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    ///   plays the role of the Creater in Factory Method Pattern
    ///   plays the role of Concrete class in Template Method Pattern
    /// </summary>
    public static class ComboBoxFiltersFactory
    {
        private static ComboBoxFilters m_ComboBoxFiltersFactory = null;

        public static ComboBox CreateFilter(ComboBox i_ComboBoxFilter)
        {
            if (i_ComboBoxFilter.Name.Contains("Gender"))
            {
                m_ComboBoxFiltersFactory = new ComboBoxGender(i_ComboBoxFilter);
            }

            if (i_ComboBoxFilter.Name.Contains("ZodiacSign"))
            {
                m_ComboBoxFiltersFactory = new ComboBoxZodiacSign(i_ComboBoxFilter);
            }

            if(i_ComboBoxFilter.Name.Contains("RelationShipStatus"))
            {
                m_ComboBoxFiltersFactory = new ComboBoxRelationShipStatus(i_ComboBoxFilter);
            }

            return (ComboBox)m_ComboBoxFiltersFactory.Create();
        }
    }
}
