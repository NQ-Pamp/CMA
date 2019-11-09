using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffectOpeConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, average;

            num1 = 10;
            num2 = 4;
            average = (num1 + num2) / 2;

            // Checking values.
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);
            Console.WriteLine("Average = " + average);

            // Changing num2 values.
            num2 += 2;

            // Check that Average has not changed.
            Console.WriteLine("Average after change = " + average);
        }
    }
}
