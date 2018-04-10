using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of Strategy in Strategy Pattern
    /// </summary>
    public interface IComparer
    {
        bool ShouldSwap(string i_Page1, string i_Page2);
    }
}
