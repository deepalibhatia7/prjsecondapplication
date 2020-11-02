using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    class NumberReverseOrder
    {
        static void Main()
        {
            int N;
            Console.WriteLine("Enter the number from where you want to reverse the order");
            N = Convert.ToInt32(Console.ReadLine());
            for ( int i=N; i>0; i--)
            {
                Console.Write(i + " ");
                

            }
           
            Console.Read();
        }
    }
}
