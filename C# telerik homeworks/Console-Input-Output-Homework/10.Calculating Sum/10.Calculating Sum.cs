using System;

namespace _10.Calculating_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            float currentSum = 1f;
            bool check = true;
            float i = 2f;
            float oldSum = 0;

            while (check && i < 20)
            {
                currentSum += 1 / i;

                if ((currentSum - oldSum) > 0.001) //if ((currentSum - oldSum) => 0.001), then "if" will not use else
                {
                    oldSum = currentSum;
                    Console.WriteLine("currentSum: " + currentSum);
                }
                else
                {
                    check = false;
                }
                i++;
            }
        }
    }
}