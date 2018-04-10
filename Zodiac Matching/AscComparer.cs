using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of ConcreteStrategyA in Strategy Pattern
    /// </summary>
    public class AscComparer : IComparer
    {
        public bool ShouldSwap(string i_Page1, string i_Page2)
        {
            return String.Compare(i_Page1, i_Page2) > 0;
        }
    }
}
