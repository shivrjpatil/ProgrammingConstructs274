using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class TwoIntegersEqualOrNot
    {
        public void TwoNum()
        {
            Console.WriteLine("Enter first integer number ");
            int A=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second integer number ");
            int B=Convert.ToInt32(Console.ReadLine());  

            if(A==B)
            {
                Console.WriteLine("The two integer nubers are equal");
            }
            else
            {
                Console.WriteLine("The two integer number are not equal");
            }
        }
            
    }
}
