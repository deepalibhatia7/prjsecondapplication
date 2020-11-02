using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    class Alphabetical_Order
    {
        static void Main()
        {
            char alphabet;
           alphabet = 'a';
            Console.WriteLine("Alphabets from a-z ");
            while (alphabet<='z')
            {
                Console.WriteLine("{0}", alphabet);
                alphabet++;
                Console.Read();

            }

        }
    }
}
