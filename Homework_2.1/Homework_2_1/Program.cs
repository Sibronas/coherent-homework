using System;

namespace Homework_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix first = new Matrix(1, 2, 3, 4);
            Matrix second = new Matrix(1, 2, 3, 4);

            // 2 4 6 4
            var third = first.Add(second);

            Console.WriteLine(first.ToString());

            if (first.Equals(second))
            {
                Console.WriteLine("Valio");
            }
        }
    }
}
