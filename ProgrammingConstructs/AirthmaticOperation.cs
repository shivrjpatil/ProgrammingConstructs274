using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class AirthmaticOperation
    {
        public void Airthmatic()
        {
            int c;
            Console.WriteLine("Enter the first number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("select which operation you want to perform");
            Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            int check=Convert.ToInt32(Console.ReadLine());  

            switch(check)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("The addition of two numbers :"+c);
                    break;
                case 2:
                    c = a - b;
                    Console.WriteLine("The substraction of two numbers :"+c);
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine("The Multiplication of two numbers :"+c);
                    break;
                case 4:
                     c= a / b;
                    Console.WriteLine("The Division of two numbers :"+c);
                    break;

            }
        }
    }
}
