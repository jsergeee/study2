﻿// Урок 3. Массивы
// домшка
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число a: ");
//         int a = Convert.ToInt32(Console.ReadLine());
//         if (a % 7 == 0 && a % 23 == 0)
//         {
//             Console.WriteLine("да");
//         }
//         else
//         {
//             Console.WriteLine("нет");
//         }
//     }
// }

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите координаты точки X и Y через пробел:"); string[] coordinates = Console.ReadLine().Split(' ');
//         int x = Convert.ToInt32(coordinates[0]);
//         int y = Convert.ToInt32(coordinates[1]);
//         if (x > 0 && y > 0)
//             Console.WriteLine("1");
//         else if (x < 0 && y > 0)
//             Console.WriteLine("2");
//         else if (x < 0 && y < 0)
//             Console.WriteLine("3");
//         else if (x > 0 && y < 0)
//             Console.WriteLine("4");
//         else
//             Console.WriteLine("Точка находится на оси координат");
//     }
// }


// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число из отрезка [10, 99]: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         int firstDigit = number / 10;
//         int secondDigit = number % 10;
//         int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; Console.WriteLine(maxDigit);
//     }
// }


// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите натуральное число N: ");
//         int N = Convert.ToInt32(Console.ReadLine());
//         if (N < 10)
//         {
//             Console.WriteLine(N);
//         }
//         else
//         {
//             while (N > 0)
//             {
//                 int currentDigit = N % 10;
//                 N /= 10;
//                 if (N > 0)
//                 {
//                     Console.Write(currentDigit + ",");
//                 }
//                 else
//                 {
//                     Console.WriteLine(currentDigit);
//                 }
//             }
//         }
//     }
// }




// // Метод по созданию массива

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//        array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }
// bool FindNumInArray(int[] array, int nun)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == nun)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// System.Console.WriteLine("Input arrray sise: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);

// System.Console.WriteLine();

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindNumInArray(array, num));


// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.


// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//        array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }
// bool FindNumInArray(int[] array, int nun)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == nun)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[]ChangeArrey(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
//     return array;
// }


// System.Console.WriteLine("Input arrray sise: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);
// System.Console.WriteLine();

// PrintArray(ChangeArrey(array));


// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] ArrayOfPars(int[] array)
// {
//     int[] numbers = new int[array.Length / 2];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         numbers[i] = array[array.Length - i - 1] * array[i];
//     }
//     return numbers;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// System.Console.WriteLine("Input arrray sise: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);
// System.Console.WriteLine();

// PrintArray(ArrayOfPars(array));



// Домашка домашка
// Задание
// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90].

// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.

// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.
