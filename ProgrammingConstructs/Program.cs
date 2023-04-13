using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programming constructs Programs");
            Console.WriteLine("1.Two Number Equal or Not\n2.Even or Odd");
            int option=Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    TwoIntegersEqualOrNot twoint = new TwoIntegersEqualOrNot();
                    twoint.TwoNum();
                    break;
                case 2:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.EvenOdd();
                    break;
            }

           
            Console.ReadLine();
        }
    }
}
