using System;

namespace _12.Sequence_of_Operators_that_Modifies_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter number n: ");
            //    int number  = int.Parse(Console.ReadLine());
            //Console.Write("Enter position: ");
            //    int position = int.Parse(Console.ReadLine());
            //Console.Write("Enter value: ");
            //    int value = int.Parse(Console.ReadLine());


            int number = 5;    //The number to modify.
            int position = 3; //Position number 3 from the binary representation of "number".
            int value = 1;   //To modify "number" to hold the value of "value" at position 3.



            Console.WriteLine("The Number 5: " + Convert.ToString(number, 2).PadLeft(32, '0')); //Print the binary representation of "number".
            //PadLeft(Int32) - Returns a new string that right-aligns the characters in this instance by padding them 
            //with spaces on the left, for a specified total length.


            //Could be: "int mask = 1 << position;" //to move only bit "1"!
            int mask = number << position; //Move three times to the left the bits of "number" in its binary representation.
            int bitNumberAtPosition = (number & mask) == 1 ? 1 : 0; //The value of the 3rd bit of binary representation of "number".


            Console.WriteLine("The value of the bit on 3rd position in the Number: " + bitNumberAtPosition); //Print the value of the 3rd bit. //0
            Console.WriteLine("Mask = moving Number's bits 3 times left: " + Convert.ToString(mask, 2).PadLeft(32, '0'));



            if (bitNumberAtPosition == 0)
            {
                number |= mask; //number = number | mask; //number = (number | (number << position)); //number |= (number << position);
            }
            else
            {
                number &= ~mask; //number = number & ~mask; //number = (number & ~(number << position); //number &= ~(number << position);
            }
            Console.WriteLine("The Number modified: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
