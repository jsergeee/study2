// int a = 5;
// Console.WriteLine(a);

// Console.WriteLine("Input number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a * a);

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.


// Console.Write("Input ferst number: " );
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 == num2 * num2)
// {
// Console.Write($"{num1} is quad of {num2}");
// }
// else
// {
//     Console.Write($"{num1} is not quad of {num2}");
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.


// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = -n;
// while (start <= n)
// {
// Console.Write(start + " ");
// start++;
// }


// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num >=100 && num <= 999)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     Console.Write($"Sum of {ed} end {sot} -> {ed + sot}");
// }
// else
// Console.Write("You input not three-digit number: ");
