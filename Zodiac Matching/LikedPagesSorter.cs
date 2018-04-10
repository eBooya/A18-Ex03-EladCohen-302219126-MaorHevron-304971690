using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of Context in Strategy Pattern
    /// </summary>
    class LikedPagesSorter
    {
        ///  My strategy
        public IComparer Comparer { get; set; }

        public LikedPagesSorter(IComparer i_Comparer)
        {
            Comparer = i_Comparer;
        }

        public void Sort(Page[] i_PagesArray)
        {
            for (int g = i_PagesArray.Length / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_PagesArray.Length; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (Comparer.ShouldSwap(i_PagesArray[j].ToString(), i_PagesArray[j + g].ToString()))
                        {
                            doSwap(ref i_PagesArray[j], ref i_PagesArray[j + g]);
                        }
                    }
                }
            }
        }

        private void doSwap(ref Page io_Page1, ref Page io_Page2)
        {
            Page tempPage = io_Page1;
            io_Page1 = io_Page2;
            io_Page2 = tempPage;
        }
    }
}
