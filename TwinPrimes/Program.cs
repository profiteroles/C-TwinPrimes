using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwinPrimes
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, count, sum, max; // Declare Variables

            
            Console.Write("Type a Number to find your Prime numbers : ");
            max = int.Parse(Console.ReadLine()); // user signs max with an input
            

            for (num = 3; num <= max; num++) // if num is lower than max keep the loop adding 1 to num integer
            {
                sum = 0; 

                for (count = 2; count <= num / 2; count++) //  if count is lower than half of the num keeps the loop and adds 1 to count
                {
                    if (num % count == 0) // if the result of num / count = 0 then adds 1 to sum 
                    {
                        sum++;
                        break;
                    }
                }

                if (sum == 0 && num != 1) // if sum = to 0 and num not = 1 then system writes twin prime numbers
                    Console.WriteLine(num + " " + (num + 2));
               
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
        /* A'NIL EROL
         * 30023737
         * 13.08.2020
         */
 
        
    
