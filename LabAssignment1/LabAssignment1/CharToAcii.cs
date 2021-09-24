using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    class CharToAcii
    {
        static void Main()
        {
            char a = 'r';
            int ASCII = (int)Convert.ToChar(a);
            Console.WriteLine("The ASCII value of" + a + "is:" + ASCII);
            Console.ReadLine();
        }
    }
}
