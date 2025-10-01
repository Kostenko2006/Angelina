using System;
namespace Task2
{
  public  class Program
    {
        public static void Main()
        {
            int[] numbers = GenerateRandomArray(10, 1, 100);

            Console.WriteLine("Згенерований масив:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Сума: {GetSum(numbers)}");
            Console.WriteLine("Середнє: {GetAverage(numbers):F2}");
            Console.WriteLine("Мінімум: {GetMin(numbers)}");
            Console.WriteLine("Максимум: {GetMax(numbers)}");
        }

        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max + 1);
            }

            return array;
        }

        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static double GetAverage(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            return (double)GetSum(numbers) / numbers.Length;
        }

        public static int GetMin(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Масив не може бути порожнім");

            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            return min;
        }

        public static int GetMax(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Масив не може бути порожнім");

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }
    }
}