using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_convert
{
    class NumberConvert
    {
        public static int BinToInt(string bin)
        {
            int bit = 0;
            int result = 0;

            // Loop starts from the end of the string because it's easier to start from LSB of binary
            for (int i = bin.Length - 1; i >= 0; i--)
            {

                // Adds the value of the corresponding bit if '1'
                if (bin[i] == '1')
                    result += Convert.ToInt32(Math.Pow(2, bit));
                bit++;
            }
            return result;
        }
    }
}
