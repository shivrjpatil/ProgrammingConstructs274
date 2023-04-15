using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class SumofsquareofNumber
    {
        public void SumSquare()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            Console.WriteLine("The sum of squares of {0} numbers starting from 1 is {1}", n, sum);
        }
    }
}
