// Создать целочисленный массив на 10
// элементов и заполнить его произвольными
// числами. Вывести на экран чётные элементы
// массива.

// int[] aray = { 1, 2, 3, 4, 5, 6};

// for (int i = 0; i < aray.Length; i++)
// {
//     if (aray[i] % 2 == 0)
//     {
//         Console.WriteLine(aray[i]);
//     }
// }

// Создать массив и заполнить его целыми
// числами от 1 до N (N – произвольное
// натуральное число). Вывести элементы
// массива на экран.


// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int des1 = (num / 100) * 10;
// int sot1 = (num / 1000) * 10;
// int tys1 = (num / 10000) * 10;
// int ed = num % 10;
// int des = (num - ed) / 10 - des1;
// int sot = (num / 100) - sot1;
// int tys = (num / 1000) - tys1;
// int destys = (num / 10000);
// int millions = (num/ 1000000);

// // Console.WriteLine($"{millions}m");

// int[] array = { destys, tys, sot, des, ed, millions};

// int i = 0;

// while (i < array.Length)
// {
//     Console.WriteLine(array[i]);
//     i++;
// }


// Создать целочисленный массив на 10
// элементов и заполнить его произвольными
// числами. Вывести на экран чётные элементы
// массива.

// int[] aray = new int[100];

// for (int i = 0; i < aray.Length; i++)
// {
//     aray[i] = new Random().Next(100, 1000);
// }

// for (int i = 0; i < aray.Length; i++)
// {
//     if (aray[i] % 2 == 0)
//     {
//         Console.WriteLine(aray[i]);
//     }
// }

// Дано 5 гирь, найти вес самой тяжелой.

// int n1 = new Random().Next(1, 1000);
// int n2 = new Random().Next(1, 1000);
// int n3 = new Random().Next(1, 1000);
// int n4 = new Random().Next(1, 1000);
// int n5 = new Random().Next(1, 1000);
// int max = n1;
// if (n2 > max)
// {
//     max = n2;
// } 

// if (n3 > max)
// {
//     max = n3;
// }
// {
//     max = n4;
// }

// if (n5 > max)
// {
//     max = n5;
// }

// Console.WriteLine($"n1= {n1},");
// Console.WriteLine($"n2= {n2},");  
// Console.WriteLine($"n3= {n3},");
// Console.WriteLine($"n4= {n4},"); 
// Console.WriteLine($"n5= {n5},");
// Console.WriteLine($"max= {max},");


// Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] aray = new int[size];

// for (int i = 0; i < aray.Length; i++)
// {
//     aray[i] = new Random().Next(10, 20);
// }
// int max = aray[0];
// for (int i = 0; i < aray.Length; i++)
// {

//     if (i < aray.Length)
//     {
//         Console.WriteLine(aray[i]);
//         // Console.WriteLine($"max {max}");
//     }

// }

// Console.WriteLine($"max {max}");
// Работает с ошибкой

// Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 

// Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] aray = new int[size];

// for (int i = 0; i < aray.Length; i++)
// {
//     aray[i] = new Random().Next(1, 100);
// }

// int count = 0;

// for (int i = 0; i < aray.Length; i++)
// {
//     if (aray[i] >= 20 && aray[i] <= 90)
//     {
//         count++;
//         Console.WriteLine(count);
//     }
// }
// с ошибкой

// 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

// Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
int[] aray = new int[10];

for (int i = 0; i < aray.Length; i++)
{
    aray[i] = new Random().Next(1, 100);
}
int even = 0;
for (int i = 0; i < aray.Length; i++)
{
    if (aray[i] % 2 == 0)
    {
        even = even++;
        
    }
    Console.WriteLine($"Чет{even}");
    Console.WriteLine(aray[i]);
}

