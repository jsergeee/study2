// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 3;
// arr[3] = 8;
// arr[4] = 1;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);
// Console.WriteLine(arr[5]);
// int[] arr2 = new int[5] {1,2,3,4,5};
// int[] arr3 = {1,2,3,4,5};
// Console.WriteLine(arr2[5]);
// int N = 10;
// int[] arr = new int[N];
// int i = 0;

// while (i < N)
// {
//     arr[i] = i + 1;
//     Console.Write($"{arr[i]} ");
//     i++;
// }

// Знакомство с языками программирования (лекции)
// Урок 3. Функции

// Вычистлить значние формулы a*b / c+d где a, b, c, d – некоторые целые числа.

// double CalculateFormula(int a, int b, int c, int d)
// {
//     int numetator = a * b;
//     int denomenator = c + d;
//     double result = numetator / denomenator;
//     return result;
// }

// double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);

// Задача 2 Вывод квадратов чисел
// Три вопрос:
// Что делает функция?
// Какие данные ей нужны для работы?
// Имеет ли фунцкия результат?
// Вывод на консоль жо попбочный эффект и функция ничего не возвращает.

// void PrintSquares (int limit)
// {
//     int i = 0;
//     while(i <= limit)
//     {
//         Console.Write($"{i * i} ");
//         i++;
//         Console.WriteLine($"переменная limit: {limit}");// добавлено мной для визулизации
//         Console.WriteLine($"переменная i: {i}"); // добавлено мной для визулизации
//     }
        
// }

// PrintSquares(5);
// PrintSquares(10);
// PrintSquares(15);
// PrintSquares(20);


// Примеры ссылочных данных

// void ZeroEvenElement(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }
//     }
// }
// void PrintArray(int[] arr)
// {
//     foreach (int e in arr)
//     {
//         Console.Write($"{e} ");
//     }
// }
// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// ZeroEvenElement(array);
// PrintArray(array);

// Примеры прменеия Функции в коде
// Дан код: (не работает) после правки висит не выдает резултат, но и ошибки не выдает

// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// while (i < n)
// {
//     arr[i] = i + 1;
// }
// // int i = 0;
// while (i < n)
// {
//     Console.Write($"{arr[i]} ");
// }
// // int i = 0;
// int sum = 0;

// while (i < n)
// {
//     sum = sum + arr[i];
// }
// // int i = 0;
// int product = 1;
// while (i < n)
// {
//     product = product * arr[i];
// }
// Console.WriteLine($"sum = {sum}");
// Console.WriteLine($"product = {product}");