using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ข้อ 4.2
            int mark = 0, i = 1;
            Dice dic1 = new Dice();

            while (mark != 1)
            {
                mark = dic1.Throw();
                Console.WriteLine("{0} Mark of Dice: {1}", i, mark);
                System.Threading.Thread.Sleep(10);
                i += 1;
            }

            Console.WriteLine("Throw of dice = 1 is: " + (i - 1) + " time");
            Console.ReadLine();

            // ข้อ 4.3
            /*int mark1 = 0, mark2 = 0, i = 1;
            Dice dic1 = new Dice();
            Dice dic2 = new Dice();

            while (mark1 != 1 && mark2 != 1)
            {
                mark1 = dic1.Throw();
                mark2 = dic2.Throw();

                Console.WriteLine("{0} Mark of Dice: {1} and {2}", i, mark1, mark2);
                System.Threading.Thread.Sleep(10);
                i += 1;
            }

            Console.WriteLine("Throw of dice = 1 is: " + (i - 1) + " time");
            Console.ReadLine();*/
        }
    }
}
