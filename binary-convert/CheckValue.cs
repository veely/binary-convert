using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_convert
{
    class CheckValue
    {
        public static bool IsBin(string value)
        {

            // Check each bit to make sure there are only 1's and 0's
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < '0' | value[i] > '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
