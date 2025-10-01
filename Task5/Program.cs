using System;
namespace Task5
{
  public  class Program
    {
        public static void Main()
        {
            int[][] groups = new int[][]
            {
            new int[] { 85, 90, 78, 92, 88, 76, 95, 83, 91, 87 },
            new int[] { 65, 72, 68, 75, 70, 80, 85, 78, 82, 90 },
            new int[] { 95, 92, 98, 96, 94, 97, 99, 93, 91, 100 }
            };

            PrintGroupStatistics(groups);
        }

        public static double GetAverage(int[] marks)
        {
            if (marks == null || marks.Length == 0)
                return 0;

            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return (double)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            if (marks == null || marks.Length == 0)
                return 0;

            int min = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] < min)
                    min = marks[i];
            }
            return min;
        }

        public static int GetMax(int[] marks)
        {
            if (marks == null || marks.Length == 0)
                return 0;

            int max = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max)
                    max = marks[i];
            }
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                double average = GetAverage(groups[i]);
                int min = GetMin(groups[i]);
                int max = GetMax(groups[i]);

                Console.WriteLine("Група {i + 1}: Середній = {average:F0}, Мінімальний = {min}, Максимальний = {max}");
            }
        }
    }
}
