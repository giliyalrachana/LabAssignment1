using System;


namespace LabAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            double PI = 3.142;
            Console.Write("Enter the radius :");
            radius = Convert.ToDouble(Console.ReadLine());
            PI = Convert.ToDouble(Console.ReadLine());
            {
                area = PI * radius * radius;
            }
            Console.WriteLine("Area of a circle:" +area);
            Console.ReadLine();

        }
    }
}
