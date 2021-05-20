using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong prevTerm = 1;//F(1)
            int index = 1;//Starting with terms F(1) = 1, F(2) = 1.
            Console.WriteLine(1 + "\tDigits: " + 1 + "\tIndex: " + index);

            ulong currentTerm = 1;//F(2)
            index = 2;
            int digits = currentTerm.ToString().Count();

            while (digits < 10)
            {
                Console.WriteLine(currentTerm + "\tDigits: " + digits + "\tIndex: " + index);
                ulong temp = currentTerm; //Holds value for currentTerm before it is updated
                currentTerm = prevTerm + currentTerm;
                prevTerm = temp; //Receives value held by currentTerm when entering loop
                digits = currentTerm.ToString().Count();
                index++; //increment index
            }
            Console.WriteLine("Number: " + currentTerm + "\tDigits: " + digits + "\tIndex: " + index);
        }
    }
}
