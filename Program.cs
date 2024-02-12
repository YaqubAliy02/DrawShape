using System;

namespace DrawShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can calculate length of the circle");
            Console.Write("Enter radius of circle:");
            string userStrInput = Console.ReadLine();
            int R = Convert.ToInt32(userStrInput);
            const float PI = 3.14f;
            float result = 2 * PI * R;
            Console.WriteLine($"The length of circle is {result}sm");

        }
    }
}
