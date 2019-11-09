using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontaine
{
    class Program
    {
        static void Main(string[] args)
        {
            // My age before drinking from the fountain.
            int myAge = 28;
            Console.WriteLine("I am " + myAge + ".");

            // Age to be removed by the fountain.
            int minusAge = 10;

            // My age after drinking.
            myAge -= minusAge;
            Console.WriteLine("I drank from the fountain ! I am now " + myAge + " :)");
        }
    }
}
