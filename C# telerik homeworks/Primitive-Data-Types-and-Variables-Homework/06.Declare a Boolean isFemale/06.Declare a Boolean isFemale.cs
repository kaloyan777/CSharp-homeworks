using System;

namespace _06.Declare_a_Boolean_isFemale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("She is a girl.");
            Console.Write("Type in her gender - male/female: ");
            string herGender = Convert.ToString(Console.ReadLine());

            bool female = true;

            if ((herGender != "male") && (herGender != "female")) //Type: kljhfgghbsdbsdlkgf
            {
                Console.WriteLine("- Restart The Program and type in correct answers!" + '\n');
            }
            else if (herGender == "male")
            {
                female = false;
                Console.WriteLine(female + ", she's a female!" + '\n');
            }
            else if (herGender == "female")
            {
                Console.WriteLine(female + ", she's a female." + '\n');
            }
            
                ///////////////////My Gender////////////////////

                    Console.Write("Type in your gender - male/female: ");
                    string myGender = Convert.ToString(Console.ReadLine());

                    if (myGender == "male")
                    {
                        Console.WriteLine("You are a dude!");
                    }
                    else if (myGender == "female")
                    {
                        Console.WriteLine("You are a girl too.");
                    }
                    else
                    {
                        Console.WriteLine('\n' + "- Restart The Program and type in correct answers!" + '\n');
                    }
                    Console.WriteLine();
                }
        }
    }
