using System;

namespace class_mathhelper
{
    public static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty.");
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return (double)sum / numbers.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            double average = MathHelper.CalculateAverage(numbers);

            Console.WriteLine("The average is: " + average);
            Console.ReadKey();
        }
    }


}
