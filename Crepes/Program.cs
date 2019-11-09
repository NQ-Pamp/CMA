using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crepes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string mySize = "";
            string tab = "\t";
            string nl = "\n";
            string recipeTitle = "##  My awesome crepes recipe  ##";

            while (recipeTitle.Length > mySize.Length)
            {
                mySize = mySize + "#";
            }

            Console.WriteLine(mySize);
            Console.WriteLine(recipeTitle);
            Console.WriteLine(mySize);
            Console.WriteLine(nl);
            Console.WriteLine(tab + "- 125g of flour");
            Console.WriteLine(tab + "- 2 Eggs");
            Console.WriteLine(tab + "- 25cl of milk");
            Console.WriteLine(tab + "- a tbsp of melted butter");
            Console.WriteLine(tab + "- a tbsp of brown sugar");
            Console.WriteLine(nl);
            Console.WriteLine(tab + "Enjoy ;)");
            Console.WriteLine(Environment.NewLine);
            */

            string name = "TOUDERT";
            int initMoney = 1000;
            int moneyTransaction;
            int newMoney;

            Console.WriteLine("Hello Mr " + name);
            Console.WriteLine("You have " + initMoney + " euros in your account.");

            //Making an operation
            moneyTransaction = 500;
            newMoney = initMoney + moneyTransaction;

            if (newMoney > initMoney)
            {
                Console.WriteLine("You have just added " + (newMoney - initMoney) + " euros to your account.");
                Console.WriteLine("You have " + newMoney + " euros in your account.");
            }
            else if (newMoney < initMoney)
            {
                Console.WriteLine("You made a withdrawal of : " + (newMoney - initMoney));
                Console.WriteLine("You have " + newMoney + " euros in your account.");
            }
            else
            {
                Console.WriteLine("Blank operation");
            }



 

        }
    }
}
