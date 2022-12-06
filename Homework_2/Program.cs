using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int arrayLenght;
        int counter = 0;

        Console.Write("Please, enter array lenght: ");
        try
        {
            arrayLenght = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLenght];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Please, enter {0} element: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i >= (array.Length / 2) && array[i] > 10)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(" ");
        }
    }
}
