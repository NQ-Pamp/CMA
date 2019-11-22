using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "October";
            string season;

            switch(month)
            {
                case "December":
                case "January":
                case "February":
                    season = "Winter";
                    Console.WriteLine("Season is : " + season);
                    break;

                case "March":
                case "April":
                case "May":
                    season = "Spring";
                    Console.WriteLine("Season is : " + season);
                    break;

                case "June":
                case "July":
                case "August":
                    season = "Summer";
                    Console.WriteLine("Season is : " + season);
                    break;

                case "September":
                case "October":
                case "November":
                    season = "Fall";
                    Console.WriteLine("Season is : " + season);
                    break;

                default:
                    season = "unknown";
                    Console.WriteLine("Season is :" + season);
                    break;

            }
        }
    }
}
