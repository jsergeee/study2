﻿// Знакомство с языками программирования (лекции)
// Урок 4. Двумерные Массивы
// • Создать двумерный массив с размерами
// 3 x 5, состоящий из целых чисел
// • Вывести его элементы на экран

// int[,] matrix = new int[2,3];
// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
        
//         matrix[i, j] = rnd.Next(1, 11);
//     }
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {

//         Console.Write ($"{matrix [i, j]} ");
//     }
//     Console.WriteLine();
// }

// Создалим через функцию двумерный массив

int[,] CreateMatrix (int rowCount, int columnCount)
{
    int [,] matrix = new int [rowCount, columnCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;

}

void ShowMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int [,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);