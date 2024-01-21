using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для завершения:");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для завершения.");
            }
        }
    }

       static bool IsSumOfDigitsEven(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum % 2 == 0;
    }
}
