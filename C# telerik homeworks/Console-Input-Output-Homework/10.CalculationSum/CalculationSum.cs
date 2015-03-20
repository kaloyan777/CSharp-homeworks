using System;

class CalculateTheSumWithAccuracy
{
    static void Main()
    {
        decimal oldSum = 1M;
        decimal newSum = 1M;
        decimal denominator = 2M;
        decimal sumDifference;
        do
        {
            oldSum = newSum;

            if (denominator % 2 == 0)
            {
                newSum += ((decimal)1 / denominator);
            }
            else
            {
                newSum -= ((decimal)1 / denominator);
            }

            denominator++;
            sumDifference = (decimal)Math.Abs(newSum - oldSum);
        } while (sumDifference >= 0.001M);

        Console.WriteLine("The sum is {0}", newSum);
    }
}


