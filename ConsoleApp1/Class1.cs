using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector V1 = new Vector(0, 0);
            Vector V2 = new Vector(5, 0);
            Vector V3 = new Vector(0, 5);

            Triangle T = new Triangle(V1, V2, V3);

            Console.WriteLine(T.contains(new Vector(1, 2)));
            Console.ReadKey();

        }
    }
}
