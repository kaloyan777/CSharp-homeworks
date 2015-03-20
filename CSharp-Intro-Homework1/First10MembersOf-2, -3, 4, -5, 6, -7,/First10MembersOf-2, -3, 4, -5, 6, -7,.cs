using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First10MembersOf_2___3__4___5__6___7_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)   //за всеки елмент от i = 2 do i <= 12("=" е за да бъде 10 включително!), прави следното:
            {
                if (i % 2 == 0)  //проверка дали i е четно
                {
                    Console.WriteLine(i); //при четните печатай моментното число
                }
                else             //ако е нечетно, печатай отрицателно
                {
                    Console.WriteLine(-i); //може и така: Console.WriteLine("-" + i);
                }
                Console.WriteLine(); //това е за да са през ред, пише се Във for(цикъла)!
            }
            //
        }
    }
}
