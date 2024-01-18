using System;

class Program
{
    static void Main()
    {
        // Задаем массив
        int[] originalArray = { 1, 2, 3, 4, 5 };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        // Переворачиваем массив
        int[] reversedArray = ReverseArray(originalArray);

        // Выводим перевернутый массив
        Console.WriteLine("Перевернутый массив:");
        PrintArray(reversedArray);
    }

    static int[] ReverseArray(int[] array)
    {
        int length = array.Length;
        int[] reversedArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            reversedArray[i] = array[length - 1 - i];
        }

        return reversedArray;
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}

