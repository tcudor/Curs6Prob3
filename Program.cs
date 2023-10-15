namespace Curs6Prob3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = ConsoleHelper.ReadNumber("The size of the array = ", 3, 0);
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                int element = ConsoleHelper.ReadNumber($"element[{i}] = ", 3, 0);
                array[i] = element;
            }
            ConsoleHelper.PrintArray("Array=", array);
            if (ArrayHelper.IsSorted(array))
            {
                int number = ConsoleHelper.ReadNumber("Elementul cautat = ", 3, 0);
                int index = ArrayHelper.BinarySearch(array, number, 0, size);

                if (index != -1)
                {
                    Console.WriteLine($"Elementul {number} a fost gasit la indexul {index}.");
                }
                else
                {
                    Console.WriteLine($"Elementul {number} nu a fost gasit în vector.");
                }
            }
            else
            {
                Console.WriteLine("Vectorul nu este sortat crescator.");
            }
        }
    }
}