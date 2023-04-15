using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programming constructs Programs");
            Console.WriteLine("1.Two Number Equal or Not\n2.Even or Odd\n3.Candidate eligible For voting\n4.Largest of Three numbers\n5.Eligibility for admission\n6.Week of the day\n7.Arithmetic Operation\n8.Power of two\n9.Sum of square of numbers\n10.Factorial of given Number\n11.FlipCoin\n12.Reverse Word\n13.Sum of Five Natural numbr");
            int option=Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    TwoIntegersEqualOrNot twoint = new TwoIntegersEqualOrNot();
                    twoint.TwoNum();
                    break;
                case 2:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.EvenOdd();
                    break;
                case 3:
                    EligibilityForVoting voting = new EligibilityForVoting();
                    voting.Vote();
                    break;
                case 4:
                    LargestOfThreeNumbers largestOfThree=new LargestOfThreeNumbers();
                    largestOfThree.Largest();
                    break;
                case 5:
                    EligibilityForAdmission admission=new EligibilityForAdmission();    
                    admission.Admission();
                    break;
                case 6:
                    WeekDay weekDay=new WeekDay();
                    weekDay.Week();
                    break;
                case 7:
                    AirthmaticOperation arithmetic=new AirthmaticOperation();
                    arithmetic.Airthmatic();
                    break;
                case 8:
                    PowerofTwo powerofTwo = new PowerofTwo();
                    powerofTwo.Power();
                    break;
                case 9:
                    SumofsquareofNumber sumofsquareofNumber=new SumofsquareofNumber();
                    sumofsquareofNumber.SumSquare();
                    break;
                case 10:
                    Factorial factorial = new Factorial();
                    factorial.Fact();
                    break;
                case 11:
                    FlipCoin flipCoin=new FlipCoin();
                    flipCoin.HeadTail();
                    break;
                case 12:
                    ReverseWord reverseWord=new ReverseWord();  
                    reverseWord.Reverse();
                    break;
                case 13:
                    SumofFiveNumbers sumofFiveNumbers=new SumofFiveNumbers();
                    sumofFiveNumbers.Sum();
                    break;
            }

           
            Console.ReadLine();
        }
    }
}
