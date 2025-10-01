using System;
namespace Task3
{
   public class Program
    {
        public static void Main()
        {
            Console.Write("Введіть ваш вік: ");
            int age;

            if (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine(ClassifyAge(age));
            }
            else
            {
                Console.WriteLine("Некоректне значення віку!");
            }
        }

        public static string ClassifyAge(int age)
        {
            if (age < 0 || age > 120)
            {
                return "Нереальний вік";
            }
            else if (age <= 11)
            {
                return "Ви дитина";
            }
            else if (age >= 12 && age <= 17)
            {
                return "Підліток";
            }
            else if (age >= 18 && age <= 59)
            {
                return "Дорослий";
            }
            else 
            {
                return "Пенсіонер";
            }
        }

    }
}