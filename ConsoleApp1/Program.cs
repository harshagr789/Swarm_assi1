using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vector
    {
        public double x;
        public double y;

        public Vector(double X, double Y)
        {
            x = X;
            y = Y;
        }

    }

    class Triangle
    {
        public Vector point1;
        public Vector point2;
        public Vector point3;

        public Triangle(Vector point_1, Vector point_2, Vector point_3)
        {
            point1 = point_1;
            point2 = point_2;
            point3 = point_3;
        }

        public double sign(Vector p1, Vector p2, Vector p3)
        {
            return (p1.x - p3.x) * (p2.y - p3.y) - (p2.x - p3.x) * (p1.y - p3.y);
        }
        public bool Contains(Vector to_check)
        {
            double d1, d2, d3;
            bool has_neg, has_pos;
            d1 = sign(to_check, point1, point2);
            d2 = sign(to_check, point2, point3);
            d3 = sign(to_check, point3, point1);
            has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(has_neg && has_pos);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Vector V1 = new Vector(0, 0);
            Vector V2 = new Vector(5, 0);
            Vector V3 = new Vector(0, 5);

            Triangle T = new Triangle(V1, V2, V3);

            Console.WriteLine(T.Contains(new Vector(1, 2)));
            Console.ReadKey();

        }
    }



}
