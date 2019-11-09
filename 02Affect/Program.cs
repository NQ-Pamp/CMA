using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Affect
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;

            a = 6;
            b = 2;
            result = a / b;
            Console.WriteLine("Resut = " + result);


            a = 4;
            b = 6;
            result = a + b / 2;
            Console.WriteLine("Result2 = " + result);

            result = (a + b) / 2;

            Console.WriteLine("Result3 = " + result);


        }
    }
}
