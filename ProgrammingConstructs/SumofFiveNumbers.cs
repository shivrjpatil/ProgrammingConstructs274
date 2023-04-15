using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class SumofFiveNumbers
    {
        public void Sum()
        {
            int num = 1;
            int sum = 0;

            while (num <= 5)
            {
                sum += num;
                num++;
            }

            Console.WriteLine("The sum of the first 5 natural numbers is: " + sum);
        }
    }
    
}
