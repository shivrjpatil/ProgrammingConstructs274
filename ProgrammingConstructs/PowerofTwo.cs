using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class PowerofTwo
    {
        public void Power()
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Powers of 2 less than or equal to 2^n:");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"2^{i} = {Math.Pow(2, i)}");
            }
        }
    }
}
