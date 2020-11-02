using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    class SumofOddNumbers
    {
        static void Main()
        {
            int i, sum=0, n;
            Console.WriteLine("Enter the number of terms");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The odd numbers are");
            for(i=1; i<=n ; i++)
            {
                Console.Write(" {0} ", ((2 * i) - 1));
                sum += 2 * i - 1;
            }
            Console.Write(" \n The Sum of odd Natural Number upto {0} terms : {1}", n, sum);
            Console.Read();
        }
    }
}
