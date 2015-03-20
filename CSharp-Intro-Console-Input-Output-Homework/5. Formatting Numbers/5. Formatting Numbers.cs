using System;

namespace _5.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c 
            //and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
            //The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, 
            //padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; 
            //the number c should be printed with 3 digits after the decimal point, left aligned. 

            //1.Напишете програма, която чете 3 числа: едно цяло, две с плаваща запетая на 4 колони. 
            //2.Всяка колона да има ширина = 10 позиции.
            //3.Цялото число да бъде изпечатано в шестнадесетичен формат, ляво подравнено, после да бъде изпечатано в двуичен формат, раздуто с нули. 
            //4.Второто число да бъде отпечатано с две цифри след десетичната запетая, дясно подравнено. 
            //5.Третото число да бъде отпечатано с три цифри след десетичната запетая, ляво подравнено.

            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:0.00}|{3, -10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
