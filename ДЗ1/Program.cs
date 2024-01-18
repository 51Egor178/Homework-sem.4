using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для завершения: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (IsEvenDigitSum(int.Parse(input)))
            {
                Console.WriteLine($"Сумма цифр числа {input} чётная. Программа завершена.");
                break;
            }
        }
    }

    static bool IsEvenDigitSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum % 2 == 0;
    }
}

