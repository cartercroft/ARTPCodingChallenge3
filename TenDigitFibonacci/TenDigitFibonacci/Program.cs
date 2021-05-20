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
            ulong prevTerm = 1;
            ulong currentTerm = 1;
            int index = 2;
            int digits = currentTerm.ToString().Count();
            while (digits < 10)
            {
                index++; //increment index

                Console.WriteLine(currentTerm + " Digits: " + digits);
                ulong temp = currentTerm; //Holds value for currentTerm before it is updated
                currentTerm = prevTerm + currentTerm;
                prevTerm = temp; //Receives value held by currentTerm when entering loop
                digits = currentTerm.ToString().Count();
            }
            Console.WriteLine("Number: " + currentTerm + "\tDigits: " + digits + "\tIndex: " + index);
        }
    }
}
