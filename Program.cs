// // using System;

// // class Program
// // {
// //     static void Main()
// //     {
// //         while (true)
// //         {
// //             Console.WriteLine("Введите целое число или 'q' для завершения:");
// //             string input = Console.ReadLine();

// //             if (input.ToLower() == "q")
// //             {
// //                 Console.WriteLine("Программа завершена.");
// //                 break;
// //             }

// //             if (int.TryParse(input, out int number))
// //             {
// //                                 if (IsSumOfDigitsEven(number))
// //                 {
// //                     Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
// //                     break;
// //                 }
// //             }
// //             else
// //             {
// //                 Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для завершения.");
// //             }
// //         }
// //     }

// //        static bool IsSumOfDigitsEven(int num)
// //     {
// //         int sum = 0;
// //         while (num != 0)
// //         {
// //             sum += num % 10;
// //             num /= 10;
// //         }

// //         return sum % 2 == 0;
// //     }
// // }

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем размер массива
//         int arraySize = 10;

//         // Создаем массив случайных трехзначных чисел
//         int[] numbersArray = GenerateRandomArray(arraySize);

//         // Выводим массив на экран
//         Console.WriteLine("Сгенерированный массив:");
//         PrintArray(numbersArray);

//         // Получаем количество четных чисел в массиве
//         int evenCount = CountEvenNumbers(numbersArray);

//         // Выводим результат
//         Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
//     }

//     // Метод для генерации массива случайных трехзначных чисел
//     static int[] GenerateRandomArray(int size)
//     {
//         Random random = new Random();
//         int[] array = new int[size];

//         for (int i = 0; i < size; i++)
//         {
//             array[i] = random.Next(100, 1000); // Генерируем трехзначное число
//         }

//         return array;
//     }

//     // Метод для вывода массива на экран
//     static void PrintArray(int[] array)
//     {
//         foreach (var number in array)
//         {
//             Console.Write(number + " ");
//         }
//         Console.WriteLine();
//     }

//     // Метод для подсчета количества четных чисел в массиве
//     static int CountEvenNumbers(int[] array)
//     {
//         int evenCount = 0;

//         foreach (var number in array)
//         {
//             if (number % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }

//         return evenCount;
//     }
// }

using System;

class Program
{
    static void Main()
    {
        int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        int[] reversedArray = ReverseArray(originalArray);

        Console.WriteLine("Перевернутый массив:");
        PrintArray(reversedArray);
    }

        static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
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
}