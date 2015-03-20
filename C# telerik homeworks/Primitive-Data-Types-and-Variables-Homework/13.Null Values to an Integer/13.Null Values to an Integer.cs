using System;

namespace _13.Null_Values_to_an_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two empty rows will be displayed
            int? nullInt = null; 
            double? nullDouble = null;

            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);

            //Adding Values
            nullInt = 3;
            nullDouble = 7;
                                                                 //If without adding values - (0,0)
            Console.WriteLine(nullInt.GetValueOrDefault());     //3
            Console.WriteLine(nullDouble.GetValueOrDefault()); //7
        }
    }
}
