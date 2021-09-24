using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    class IntParse
    {
        static void Main()
        {
            Console.Write("Enter the age:");
            string ageAsString = Console.ReadLine();
            int ageAsInt = int.Parse(ageAsString);
            Console.WriteLine("The age is = " + ageAsInt);
            Console.ReadLine();
        }
    }
}
