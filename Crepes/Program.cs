using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crepes
{
    class Program
    {

        static int initMoney;
        static int newMoney;

        static void SayHi(string name)
        { 
            Console.WriteLine("Hello Mr " + name);
            initMoney = 1000;
            Console.WriteLine("You have " + initMoney + " euros in your account.\n");
        }

        static void MakeOps(int ammount)
        {
            newMoney = initMoney + ammount;

            if (ammount > 0)
            {
                Console.WriteLine("You have just added " + (newMoney - initMoney) + " euros to your account.");
                Console.WriteLine("You now have " + newMoney + " euros in your account.\n");
            }
            else if (ammount < 0)
            {
                Console.WriteLine("You made a withdrawal of : " + (newMoney - initMoney));
                Console.WriteLine("You now have " + newMoney + " euros in your account.\n");
            }
            else
            {
                Console.WriteLine("Blank operation");
            }

            initMoney = newMoney;
        }

        static void Main(string[] args)
        {

            SayHi("TOUDERT");
            MakeOps(500);
            MakeOps(-400);
            MakeOps(-1000);
            MakeOps(2500);

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
        }
    }
}
