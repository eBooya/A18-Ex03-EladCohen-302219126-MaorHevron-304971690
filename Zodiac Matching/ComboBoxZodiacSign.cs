using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of specific product in Factory Method Pattern
    /// plays the role of Concrete class in Template Method Pattern
    /// </summary>
    public class ComboBoxZodiacSign : ComboBoxFilters
    {
        public ComboBox ZodiacSignComboBox { get; set; }

        public ComboBoxZodiacSign(ComboBox i_ComboBoxZodiacSign)
        {
            ZodiacSignComboBox = i_ComboBoxZodiacSign;
        }

        public override ComboBox Create()
        {
            int eZodiacSignsLength = Enum.GetNames(typeof(ZodiacSign.eZodiacSigns)).Length;
            List<string> ZodiacSigns = new List<string>();
            for (int i = 0; i < eZodiacSignsLength; i++)
            {
                ZodiacSigns.Add(ZodiacSign.eZodiacSigns.GetName(typeof(ZodiacSign.eZodiacSigns), i));
            }

            insertComboBoxParams(ZodiacSignComboBox, ZodiacSigns);
            return ZodiacSignComboBox;
        }
    }
}