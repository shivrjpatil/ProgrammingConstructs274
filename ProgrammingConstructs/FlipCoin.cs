using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class FlipCoin
    {
        public void HeadTail()
        {
            int headsCount = 0;
            int tailsCount = 0;
            Random rand = new Random();

            while (true)
            {
                //flipping a coin
                int result = rand.Next(2);

                if (result == 0)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }

                // Check if either Heads or Tails has won 20 times
                if (headsCount == 20)
                {
                    Console.WriteLine("Heads has won 20 times!");
                    break;
                }
                else if (tailsCount == 20)
                {
                    Console.WriteLine("Tails has won 20 times!");
                    break;
                }
            }
        }
    }
}
