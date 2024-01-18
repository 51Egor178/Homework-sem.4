using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int arraySize = 10;
        
        // Создаем массив случайных трехзначных чисел
        int[] randomNumbers = GenerateRandomNumbers(arraySize);

        // Выводим содержимое массива
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(randomNumbers);

        // Подсчитываем количество чётных чисел в массиве
        int evenCount = CountEvenNumbers(randomNumbers);

        // Выводим результат
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    }

    static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(100, 1000); // случайное трехзначное число
        }

        return numbers;
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
