using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First1000Members
{
    class First1000Members
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if(i % 2 != 0)
                {
                    Console.WriteLine(-i);
                }
                Console.WriteLine();
            }
        }
    }
}
