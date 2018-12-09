using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class CyclomaticComplexity
    {
        static void Main()
        {
            int a = 1, b = 1;

            for (int x = 0; x < 10; x++)
            {
                b += x;
            }

            if (a > b)
            {
                Console.WriteLine("a is bigger than b.");
            }
            else
            {
                Console.WriteLine("a is smaller than b.");
            }

        }
    }
}
