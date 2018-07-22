using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20NewFeatures
{
    class SwapExample<T>
    {
        public void Swap(ref T a,ref T b)
        {
            //ref is used for call by reference as pointer is not supported in C#
            T temp = a;
            a = b;
            b = temp;
            // ref keyword is used in place of * and &
        }
    }
}
