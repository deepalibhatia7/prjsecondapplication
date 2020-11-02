using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    class CountDigits
    {
        static int countDigit(long n)
        {
            if (n == 0)
                return 0;
            return 1 + countDigit(n / 10);
        }

        /* Driver program to test above 
        function */
        public static void Main()
        {
            Console.WriteLine("Enter the number");
            long n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of digits : " + countDigit(n));
            Console.Read();
        }
        
    }
}
