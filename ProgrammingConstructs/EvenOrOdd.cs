using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class EvenOrOdd
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter the number");
            int A=Convert.ToInt32(Console.ReadLine());

            if(A%2==0)
            {
                Console.WriteLine("The Entered number is EVEN");
            }
            else
            {
                Console.WriteLine("The Entered number is ODD");
            }
        }
    }
}
