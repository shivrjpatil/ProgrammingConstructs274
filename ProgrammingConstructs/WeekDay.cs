using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class WeekDay
    {
        public void Week()
        {
            Console.WriteLine("Enter the number Between 1 to 7");
            int Num=Convert.ToInt32(Console.ReadLine());
            switch(Num)
            {
                case 1:
                    Console.WriteLine("sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("saturday");
                    break;
                    default:
                    Console.WriteLine("you have entered Wrong option");
                    break;
            }
        }
    }
}
