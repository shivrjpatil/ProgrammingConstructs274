using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class Factorial
    {
        public void Fact()
        {
            Console.WriteLine("enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("{0}! = {1}", n, result);
        }
    }
}
