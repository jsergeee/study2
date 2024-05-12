

//УКвадрать числа
// Console.Write("Input number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write(num1*num1);

// сложить два числа
// Console.Write("Введите число 1: ");
// double номер1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число 2: ");
// double номер2 = Convert.ToDouble(Console.ReadLine());
// Console.Write(номер1 + номер2);

//Калькулятор сделал сам
// Console.Write("Введите число 1: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число 2: ");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введиете опрацию: ");
// char o = Convert.ToChar(Console.ReadLine());

// if(o == '+')
// {
//     Console.Write($"Сумма {a} и {b} равна {a + b}");
// }
// if (o == '-')
// {
//     Console.Write($"Разница {a} и {b} равна {a - b}");
// }
// if(o == '*')
// {
//     Console.Write($"Приозведение {a} и {b} равно {a * b}");
// }
// if (o == '/')
// {
//     Console.Write($"{a} разделить на {b} равно {a / b}");
// }


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

// Напишите программу, которая выводит третью с 
// конца цифру заданного числа или сообщает, что 
// третьей цифры нет


// Console.Write("Input N: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num >= 100 && num <= 999)
//     {
//     int sot = num / 100;
//     Console.Write($"Третья с конца цифра числа {num} -> {sot}");
//     }
//     else
//         Console.Write("Третьей цифры нет: ");

//     if(num >= 1000 && num <= 9999)
//     {
//         int tys = num / 1000;
//         Console.Write($"Третья с конца цифра числа {num} -> {tys}");
//     }
//     if(num >= 10000 && num <= 99999)
//     {
//         int destys = num / 10000;
//         Console.Write($"Третья с конца цифра числа {num} -> {destys}");
//     }
//     if(num >= 100000 && num <= 999999)
//     {
//         int stotys = num / 100000;
//         Console.Write($"Третья с конца цифра числа {num} -> {stotys}");
//     }
//     if(num >= 1000000 && num <= 9999999)
//     {
//         int millions = num / 1000000;
//         Console.Write($"Третья с конца цифра числа {num} -> {millions}");
//     }

// Задача 1: Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23

// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0)
// {
//     Console.Write($"Число {num} кратно 7 и 23");
// }
// else
//     if (num % 23 == 0)
//     {
//     Console.Write($"Число {num} кратно 7 и 23");
//     }
//     else
//         Console.Write($"Число {num} не кратно 7 и 23");


// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int n = 1;

// while (n <= num)
// {
//     if (n % 7 == 0)
//     {
//         Console.Write(n);
//         Console.Write(" (Кратно 7) ");
//     }
//     else
//         if (n % 23 == 0)
//         {
//         Console.Write(n);
//         Console.Write(" (Кратно 23) ");
//         }

//         n++;
// }


// Задача 2: Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
// Если точка имеет положительную координату X  и положительную координату Y , то она лежит в первой четверти.
// Если точка имеет отрицательную координату X  и положительную координату Y , то она лежит во второй четверти.
// Если точка имеет отрицательную координату X  и отрицательную координату Y , то она лежит в третьей четверти.
// Если точка имеет положительную координату X и отрицательную координату Y , то она лежит в четвертой четверти.

// Console.Write("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.Write("Точка лежит в первой четверти");
// }
// if (x < 0 && y > 0)

// {
//     Console.Write("Точка лежит во второй четверти");
// }
// if (x < 0 && y < 0)

// {
//     Console.Write("Точка лежит в третьей четверти");
// }

// if (x > 0 && y < 0)

// {
//     Console.Write("Точка лежит в четвертой четверти");
// }




//  Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа

// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 10 && num <= 99)
// {
//     int ed = num % 10;
//     int sot = num / 10;
//     if (ed > sot)
//     {
//         Console.Write($"Наибольшая цифра числа {num} -> {ed}");
//     }
//     else
//     {
//         Console.Write($"Наибольшая цифра числа {num} -> {sot}");
//     }
// }



// Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.

// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 0 && num <=9)
// {
//         Console.Write($"Число {num}");
// }
// if (num >= 10 && num <= 99)
// {
//     int ed = num % 10;
//     int des = (num - ed) / 10;
//     Console.Write($"Число {num} -> {des}, {ed}");
// }
// if(num >= 100 && num <= 999)
// {
//     int ed = num % 10;
//     int des = (num % 100 - ed) / 10;
//     int sot = num / 100;
//     Console.Write($"Число {num} -> {sot}, {des}, {ed}");
// }
// if(num >= 1000 && num <= 9999)
// {
//     int ed = num % 10;
//     int des = (num % 100 - ed) / 10;
//     int sot = num % 100;
//     int tys = num / 1000;
//     Console.Write($"Число {num} -> {tys}t, {sot}s, {des}d, {ed}e");
// }

// if(num >= 10000 && num <= 99999)
// {
//     int ed = num !% 10;
//     int des = (num !% 100 - ed) / 10;
//     int sot = num !% 100;
//     int tys = num !% 1000;
//     int destys = num !% 10000;
//     Console.Write($"Число {num} -> {destys}dt, {tys}t, {sot}s, {des}d, {ed}e");
// }

//Делал сам

Console.Write("Input N: ");
int num = Convert.ToInt32(Console.ReadLine());
int des1 = (num / 100) * 10;
int sot1 = (num / 1000) * 10;
int tys1 = (num / 10000) * 10;
int ed = num % 10;
int des = (num - ed) / 10 - des1;
int sot = (num / 100) - sot1;
int tys = (num / 1000) - tys1;
int destys = (num / 10000);
if (num > 0 && num <= 9)
{
    Console.Write($"{ed} ");
}
if (num > 10 && num <= 99)
{
    Console.Write($"{des}, ");
    Console.Write($"{ed} ");
}
if (num > 99 && num <= 999)
{
    Console.Write($"{sot}, ");
    Console.Write($"{des}, ");
    Console.Write($"{ed} ");
}
if(num > 999 && num <= 9999)
{
    Console.Write($"{tys}, ");
    Console.Write($"{sot}, ");
    Console.Write($"{des}, ");
    Console.Write($"{ed} ");
}

if(num > 9999 && num <= 99999)
{
    Console.Write($"{destys}, ");
    Console.Write($"{tys}, ");
    Console.Write($"{sot}, ");
    Console.Write($"{des}, ");
    Console.Write($"{ed} ");
}








