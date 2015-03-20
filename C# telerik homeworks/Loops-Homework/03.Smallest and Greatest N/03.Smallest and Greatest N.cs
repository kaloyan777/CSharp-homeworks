using System;

namespace _03.Smallest_and_Greatest_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
            //--Below this code is the code only, without any comments--

//..........Example 1:

            Console.Write(">> Enter Int Number for length of Sequence to be created: ");
                int sequenceLength = int.Parse(Console.ReadLine());
                Console.WriteLine(new String('-', 40));

                int minimalN = int.MaxValue; //The variables are named oposite of their values, because later, when the logic
                int maximalN = int.MinValue; //in the if-s is made(checked), their names(minN/maxN) will be printed according to
            //the logic of the condition of the task that has to be solved! 
            //  SO IT'S NOT a matter of mathematical calculation, but proving two(true) if-statements in order to name the two variables 
            //usefully for solving the task.

                for (int i = 0; i < sequenceLength; i++) //After the length of the sequence has been given(sequenceLength), 
			    {
                    Console.Write("- Element: ");
                    int number = int.Parse(Console.ReadLine()); //give the chance to enter that many times any int"number", chosen randomly.

                    if (number > maximalN) //If the "number"(reached at the moment from the encircling of the "for" loop) is > maximalN(which is the MINIMAL! value of the range of Integer numbers!, even though it's named "maximalN"!),
                    {                      //and of course it will be > than the smallest int number in the range of ints(named maximalN),
                        maximalN = number; //then make so, that this "number" = the variable called "maximalN"! (the goal is to get it's name)
                    }
                    if (number < minimalN) //...same logic...
                    {
                        minimalN = number;
                    }
			    }
                    Console.Beep(); //The "Job well done!" sound.
                    Console.WriteLine(new String('=', 40)); //some Special Web Design Skills I have! ;D
                Console.WriteLine("* Minimal Int in Sequence is: " + minimalN); //Now, print the processed values of the variables, разби'йш'и?!
                Console.WriteLine("* Maximal Int in Sequence is: " + maximalN + '\n');


//................Just the Code(example 1):

                //Console.Write(">> Enter Int Number for length of Sequence to be created: ");
                //int sequenceLength = int.Parse(Console.ReadLine());
                //Console.WriteLine(new String('-', 40));

                //int minimalN = int.MaxValue; 
                //int maximalN = int.MinValue;

                //for (int i = 0; i < sequenceLength; i++) 
                //{
                //    Console.Write("- Element: ");
                //    int number = int.Parse(Console.ReadLine());

                //    if (number > maximalN) 
                //    {                      
                //        maximalN = number; 
                //    }
                //    if (number < minimalN) 
                //    {
                //        minimalN = number;
                //    }
                //}
                //Console.Beep(); 
                //Console.WriteLine(new String('=', 40)); 
                //Console.WriteLine("* Minimal Int in Sequence is: " + minimalN); 
                //Console.WriteLine("* Maximal Int in Sequence is: " + maximalN + '\n');

//..............Example 2:

                //Console.Write("Enter Int Number for the count of members of the Sequence: ");
                //    int members = int.Parse(Console.ReadLine());
                //Console.WriteLine(new String('-', 40)); 

                //    int biggest = 0;
                //    int smallest = 0;

                //    for (int i = 0; i < members; i++)
                //    {
                //        int number = int.Parse(Console.ReadLine());
                //        if (i == 0)
                //        {
                //            biggest = smallest = number;
                //        }
                //        else if (biggest < number)
                //        {
                //            biggest = number;
                //        }
                //        else if (smallest > number)
                //        {
                //            smallest = number;
                //        }
                //    }
                //    Console.WriteLine(new String('=', 40)); 
                //    Console.WriteLine("Smallest = {0}, Biggest = {1}", smallest, biggest + '\n');
            }
        }
    }