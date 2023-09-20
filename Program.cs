using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.palindrome_number
{
    internal class Program
    {
        static int Main(string[] args)
        {
            int x = 12312312;
            if (x > 0)
            {
                int length = (int)Math.Floor(Math.Log10((double)x)) + 1;
                int temp_left = (int)Math.Pow(10, length - 1);
                int temp_right = 1;

                for (int i = 0; i < length / 2; i++)
                {
                    if ((x / temp_left) % 10 != (x / temp_right) % 10)
                    {
                        return 0;
                    }
                    else
                    {
                        temp_left /= 10;
                        temp_right *= 10;
                    }
                }
                return 1;
            }
            else
            {
                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
