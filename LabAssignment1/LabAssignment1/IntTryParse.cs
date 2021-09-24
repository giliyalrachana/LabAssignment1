using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    class IntTryParse
    {
        static void Main()
        {
            String str = "94";
            int number;
            bool flag = int.TryParse(str, out number);
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
