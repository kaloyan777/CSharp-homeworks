using System;

namespace _09.Cathalan_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
            //0 < n <32768
            //Изразът се пресмята по фомула, като първо се изчисляват факториелите и степените.
            //Съществува и оптимизиран вариaнт, при който някои от умноженията във факториела се съкращават.

            //И двете решения не са (изцяло)мои.

//..........Example 1:

            Console.Write("N: ");
                int n = int.Parse(Console.ReadLine());

                int num = 2 * n;
                int denominator = n;

                int denomResult = 1;
                int numResult = 1;
                int result = 0;

            for (int i = 0; i < n - 1; i++)
            {
                numResult *= num;
                num--;
                denomResult *= denominator;
                denominator--;
            }
            result = (numResult / denomResult);

                   Console.Beep();
                   Console.WriteLine(new String('=', 40));
            System.Console.WriteLine("- Result Catalan formula: " + result);


//..........Example 2:

            System.Console.Write("N: ");
                int N = int.Parse(Console.ReadLine());

                int n2Factoriаl = 1;
                int nFactoriаl = 1;
                int n1Factoriаl = 1;

            for (int i = 1; i <= 2 * N; i++)
            {
                n2Factoriаl *= i;
            }

            for (int i = 1; i <= N; i++)
            {
                nFactoriаl *= i;
            }
                   n1Factoriаl = nFactoriаl * (N + 1);
                   double c = (double)n2Factoriаl / ((double)n1Factoriаl * (double)nFactoriаl);

                   Console.WriteLine(new String('=', 40));
                   Console.Beep();
            System.Console.WriteLine("- Result Catalan formula: " + c + '\n');
        }
    }
}