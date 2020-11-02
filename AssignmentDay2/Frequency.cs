using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    class Frequency
    {
        static void Main()
        {
            int[] array1 = new int[100];
            int[] frequency1 = new int[100];
            int n, i, j, ctr;

            Console.WriteLine("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
                frequency1[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (array1[i] == array1[j])
                    {
                        ctr++;
                        frequency1[j] = 0;
                    }
                }

                if (frequency1[i] != 0)
                {
                    frequency1[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (frequency1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", array1[i], frequency1[i]);
                }
            }
            Console.Read();
        }
    }
}
