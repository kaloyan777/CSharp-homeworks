using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sorting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number n and a sequence of n integers, sorts them and prints them.
            //ex: 5 -> 1,3,5,4,2 -> 1,2,3,4,5

            //EXAMPLE 1:

            int n = int.Parse(Console.ReadLine()); //1. Create
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++) //2. Fill elements with values
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);                     //3. Sort the elements
            Console.WriteLine("Sorted Array: ");
             
            foreach (var item in array)            //4. Print the elements
            {
                Console.WriteLine(item);
            }
                                                   //5. Drink a glass of cold water (...don't forget to belch!)

                                                    

            //EXAMPLE 2:

            //static void Main(string[] args)
            //{

            Console.Write("Size of arrays of numbers: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbersToSort = new int[size];

            ArrayOfNumbers(numbersToSort);

            foreach (var item in numbersToSort) //print rezult
            {
                Console.WriteLine(item);
            }
        }

        private static void ArrayOfNumbers(int[] numbers) //the parameter is an array
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); //set values
            }
            Console.WriteLine("Sorted numbers: ");
            Array.Sort(numbers); //arrange the numbers in order using Array.Sort(...);
        }
    }
}


            /*      http://www.csharp-examples.net/sort-array/
             
                    Sorting Arrays [C#]:

                    This example shows how to sort arrays in C#. Array can be sorted using static method Array.
                    Sort which internally use Quicksort algorithm.
               
                    Sorting array of primitive types
                    To sort array of primitive types such as int, double or string use method Array.Sort(Array) with the array as a paramater. 
                    The primitive types implements interface IComparable, which is internally used by the Sort method 
                    (it calls IComparable.Com­pareTo method). See example how to sort int array:

                    [C#]
                    // sort int array
                    int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
                    Array.Sort(intArray);
                    // write array
                    foreach (int i in intArray) Console.Write(i + " ");  // output: 2 3 6 8 10

                    or how to sort string array:

                    [C#]
                    // sort string array
                    string[] stringArray = new string[5] { "X", "B", "Z", "Y", "A" };
                    Array.Sort(stringArray);
                    // write array
                    foreach (string str in stringArray) Console.Write(str + " "); // output: A B X Y Z

                    Sorting array of custom type using delegate
                    To sort your own types or to sort by more sophisticated rules, you can use delegate to anonymous method. 
                    The generic delegate Comparison<T> is declared as public delegate int Comparison<T> (T x, T y). 
                    It points to a method that compares two objects of the same type. It should return less then 0 when X < Y, 
                    zero when X = Y and greater then 0 when X > Y. The method (to which the delegate points) 
                    can be also an anonymous method (written inline).
               
                    Following example demonstrates how to sort an array of custom type using the delegate to anonynous comparison method. 
                    The custom type in this case is a class User with properties Name and Age.

                    [C#]
                    // array of custom type
                    User[] users = new User[3] { new User("Betty", 23),  // name, age
                                                 new User("Susan", 20),
                                                 new User("Lisa", 25) };

                    [C#]
                    // sort array by name
                    Array.Sort(users, delegate(User user1, User user2) {
                                        return user1.Name.CompareTo(user2.Name);
                                      });
                    // write array (output: Betty23 Lisa25 Susan20)
                    foreach (User user in users) Console.Write(user.Name + user.Age + " ");

                    [C#]
                    // sort array by age
                    Array.Sort(users, delegate(User user1, User user2) {
                                        return user1.Age.CompareTo(user2.Age); // (user1.Age - user2.Age)
                                      });
                    // write array (output: Susan20 Betty23 Lisa25)
                    foreach (User user in users) Console.Write(user.Name + user.Age + " ");

                    Sorting array using IComparable
                    If you implement IComparable interface in your custom type, you can sort array easily like in the case of primitive types. 
                    The Sort method calls internally IComparable.Com­pareTo method.

                    [C#]
                    // custom type
                    public class User : IComparable
                    {
                      // ...

                      // implement IComparable interface
                      public int CompareTo(object obj)
                      {
                        if (obj is User) {
                          return this.Name.CompareTo((obj as User).Name);  // compare user names
                        }
                        throw new ArgumentException("Object is not a User");
                      }
                    }

                    Use it as you sorted the primitive types in the previous examples.

                    [C#]
                    // sort using IComparable implemented by User class
                    Array.Sort(users);  // sort array of User objects


                    See also
                    [C#] Read-only wrapper for a collection – public property with read-only collection
                    Array.Sort – MSDN – static method to sort array (overload list)
                    Array.Sort(Arra­y) – MSDN – sort using IComparable interface (supported by int or string)
                    IComparable – MSDN – interface implemented by objects in array (used by Sort method)
                    Array.Sort(Array, Comparison) – MSDN – sort using generic Comparison delegate
                    Comparison<T> – MSDN – delegate to method that compares two objects
           
             */
