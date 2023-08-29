using System;


namespace searchspecificvalue_returnindex_usingloop_inarray
{
    class Program
    {
        static int SearchValueInArray(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; // Return the index if the target value is found
                }
            }
            return -1; // Return -1 if the target value is not found in the array
        }

        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.Write("Enter a value to search for: ");
            int targetValue = int.Parse(Console.ReadLine());

            int index = SearchValueInArray(numbers, targetValue);

            if (index != -1)
            {
                Console.WriteLine($"Value {targetValue} found at index {index}");
            }
            else
            {
                Console.WriteLine($"Value {targetValue} not found in the array");
            }
            Console.ReadKey();
        }
    }

}
