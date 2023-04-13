using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class LargestOfThreeNumbers
    {
        public void Largest()
        {
            Console.WriteLine("Enter the first number");
            int A=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int B=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Number");
            int C=Convert.ToInt32(Console.ReadLine());

            if (A > B && A > C)
            {
                Console.WriteLine("The first number is Largest");
            }
            else if (B>A && B>C)
            {
                Console.WriteLine("The Second number is Largest");
            }
            else
            {
                Console.WriteLine("The Third number is Largest");
            }
                
        }
    }
}
