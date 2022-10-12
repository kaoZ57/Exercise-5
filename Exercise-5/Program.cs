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

        }
    }
}
