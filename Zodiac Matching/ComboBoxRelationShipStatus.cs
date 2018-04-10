using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of specific product in Factory Method Pattern
    /// plays the role of Concrete class in Template Method Pattern
    /// </summary>
    public class ComboBoxRelationShipStatus : ComboBoxFilters
    {
        public ComboBox RelationShipStatusComboBox { get; set; }

        public ComboBoxRelationShipStatus(ComboBox i_ComboBoxRelationShipStatus)
        {
            RelationShipStatusComboBox = i_ComboBoxRelationShipStatus;
        }

        public override ComboBox Create()
        {
            int eRelationShipStatusLength = Enum.GetNames(typeof(User.eRelationshipStatus)).Length;
            List<string> RelationShipStatus = new List<string>();
            for (int i = 0; i < eRelationShipStatusLength; i++)
            {
                RelationShipStatus.Add(User.eRelationshipStatus.GetName(typeof(User.eRelationshipStatus), i));
            }

            insertComboBoxParams(RelationShipStatusComboBox, RelationShipStatus);
            return RelationShipStatusComboBox;
        }
    }
}
