using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    class ValuefromAdmin
    {
        int CourseID(int Cid)
        {
            return Cid;
        }


        void DisplayingUserDetails(string Cn,int Cid)
        {
            //calling one method from another
            int C = CourseID(Cid);
            Console.WriteLine("Course Name and Course ID is:{0} {1} ", Cn ,C);
          

        }
        int FeeAmount(int FA)
        {
            Console.WriteLine("The Fee Amount is {0}", FA);
            return FA;
        }

        static void Main()
        {
            string CName;
            int CourId, FEEAMOUNT;
            Console.WriteLine("Enter Course Name");
            CName = Console.ReadLine();
            Console.WriteLine("Enter Course ID");
            CourId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Fee Amount");
            FEEAMOUNT = Convert.ToInt32(Console.ReadLine());
            ValuefromAdmin ValuefromAdmin = new ValuefromAdmin();
            ValuefromAdmin.DisplayingUserDetails(CName, CourId);
            ValuefromAdmin.FeeAmount(FEEAMOUNT);

            Console.Read();
        }
    }
}
