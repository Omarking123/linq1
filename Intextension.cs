using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    internal static class Intextension
    {
        public static int Revers (this int mumber)
        {
            int reversedNumber = 0 ,lastdigit;

            while (mumber > 0)
            {
                lastdigit = mumber % 10;
                reversedNumber = reversedNumber * 10 + lastdigit;
                mumber /= 10;
            }


            return reversedNumber;

        }
    }
}
