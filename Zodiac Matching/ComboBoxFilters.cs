using System.Collections.Generic;
using System.Windows.Forms;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of IProduct (abstract class) in Factory Method Pattern
    /// plays the role of Abstract Class in Template Method Pattern
    /// </summary>
    public abstract class ComboBoxFilters
    {
        public static void insertComboBoxParams(ComboBox i_ComboBoxSource, List<string> i_ItemsToAdd)
        {
            foreach (string item in i_ItemsToAdd)
            {
                i_ComboBoxSource.Items.Add(item);
            }
        }

        public abstract ComboBox Create();
    }
}
