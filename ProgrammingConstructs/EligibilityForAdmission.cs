using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class EligibilityForAdmission
    {
        public void Admission()
        {
            Console.WriteLine("Enter the Marks in Maths");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks in Maths");
            int P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks in Maths");
            int C = Convert.ToInt32(Console.ReadLine());
            int Sum = M + P + C;
            int MP = M + P;
            int MC = M + C;
            if (M >= 65 && P >= 55 && C >= 50 && Sum >= 180)

                Console.WriteLine("Candidate Eligible for admision");
            else if (M >= 65 && P >= 55 && C >= 50 && MP >= 140 || MC >= 140)
                Console.WriteLine("Candidate Eligible for Admission ");

            else
                Console.WriteLine("Candidate is not eligible for admission");
        }
    }
}
