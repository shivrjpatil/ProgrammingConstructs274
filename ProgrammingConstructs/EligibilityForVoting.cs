using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class EligibilityForVoting
    {
        public void Vote()
        {
            Console.WriteLine("Enter Your Age");
            int Age=Convert.ToInt32(Console.ReadLine());

            if(Age>18)
            {
                Console.WriteLine("Candidate Eligible for Voting");
            }
            else
            {
                Console.WriteLine("Candidate not Eligible for Voting");
            }
        }
    }
}
