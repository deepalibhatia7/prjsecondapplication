using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    class ReverseNumber
    {
        static void Main()
        {
            int num, reverse, sum = 0, t;
                    

            Console.WriteLine("Input a number");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                reverse = t % 10;
                sum = sum * 10 + reverse;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);
            Console.Read();
        }
    }
}
