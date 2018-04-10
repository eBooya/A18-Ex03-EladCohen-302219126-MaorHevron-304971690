using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of specific product in Factory Method Pattern
    /// </summary>
    public class ComboBoxGender : ComboBoxFilters
    {
        public ComboBox GenderComboBox { get; set; }

        public ComboBoxGender(ComboBox i_ComboBoxGender)
        {
            GenderComboBox = i_ComboBoxGender;
        }

        public override ComboBox Create()
        {
            int eGenderLength = Enum.GetNames(typeof(User.eGender)).Length;
            List<string> Gender = new List<string>();
            for (int i = 0; i < eGenderLength; i++)
            {
                Gender.Add(User.eGender.GetName(typeof(User.eGender), i));
            }

            insertComboBoxParams(GenderComboBox, Gender);

            return GenderComboBox;
        }
    }
}