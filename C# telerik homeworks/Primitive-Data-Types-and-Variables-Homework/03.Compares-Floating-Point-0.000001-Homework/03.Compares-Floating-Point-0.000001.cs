using System;

namespace _03.Compares_Floating_Point_0._000001_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
//            decimal a = 5.0002030m;
//            decimal b = 4.0000013423m;

//            decimal roundA = Math.Round(a, 6);
//            decimal roundB = Math.Round(b, 6);

//            if (roundA == roundB)
//            {
//                Console.WriteLine("A & B are equal!");
//            }
//            else if (roundA > roundB)
//            {
//                Console.WriteLine("A is greater than B.");
//            }
//            else
//            {
//                Console.WriteLine("B is greater than A.");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Info on Example
            Console.WriteLine("A = 5.3; B = 6.01");
            Console.WriteLine("C = 5.00000001; D = 5.00000003" + '\n');

            //////////////////////////////Example 1//////////////////

            float a = 5.3f;
            float b = 6.01f;
            bool isAEqualToB = (Math.Abs(a - b) < 0.000001f);

            Console.WriteLine("Is A = B? - " + isAEqualToB);

            //////////////////////////////Example 2//////////////////

            float c = 5.00000001f;
            float d = 5.00000003f;
            bool isCEqualToD = (c == d);

            Console.WriteLine("Is C = D? - " + isCEqualToD);
        }
    }
}
