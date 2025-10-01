using System;

namespace Task4
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введіть три сторони трикутника:");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Помилка: всі сторони повинні бути додатними числами!");
                return;
            }

            if (!IsValidTriangle(a, b, c))
            {
                Console.WriteLine("Ці сторони не можуть утворювати трикутник!");
                return;
            }

            double perimeter = GetPerimeter(a, b, c);
            double area = GetArea(a, b, c);
            string type = GetTriangleType(a, b, c);

            Console.WriteLine($"Периметр: {perimeter:F2}");
            Console.WriteLine($"Площа: {area:F2}");
            Console.WriteLine($"Тип трикутника: {type}");
        }

        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c && a + c > b && b + c > a;
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("Сторони не утворюють трикутник.");
            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("Сторони не утворюють трикутник.");

            double p = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("Сторони не утворюють трикутник.");

            if (a == b && b == c)
                return "рівносторонній";

            if (a == b || a == c || b == c)
                return "рівнобедрений";

            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;

            if (Math.Abs(a2 + b2 - c2) < 0.0001 ||
                Math.Abs(a2 + c2 - b2) < 0.0001 ||
                Math.Abs(b2 + c2 - a2) < 0.0001)
                return "прямокутний";

            return "довільний";
        }

    }
}
