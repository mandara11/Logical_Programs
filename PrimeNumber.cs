using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            int count = 0;

            Console.WriteLine("Check the Number is Prime or not");

            Console.Write("Entere the Number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(num + " is Prime Number\n");
            }
            else
            {
                Console.WriteLine(num + " is Not Prime Number\n");
            }
        }
    }
}
