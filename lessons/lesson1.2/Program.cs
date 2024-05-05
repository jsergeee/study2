Console.WriteLine("Две гири");


int a1 = 5;
int b1 = 7;

if (a1 > b1)
{
    Console.WriteLine(a1);
}
else
{
    Console.WriteLine(b1);
}

Console.WriteLine("пять гирь");
int a = 6;
int b = 7;
int c = 8;
int d = 9;
int e = 10;
int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

if (d > max)
{
    max = d;
}

if (e > max)
{
    max = e;
}

Console.WriteLine(max);

Console.WriteLine("Вывести числа от 1 до N");

int n = 100;
int i = 1;
int max1 = n;// это добавил я 

while (i <= n)
{
    Console.Write(i); // это добавил я 
    Console.Write("-");// это добавил я 
    Console.Write(max1);
    Console.Write(" ");
    i = i + 1;
}
Console.WriteLine(" ");

Console.WriteLine("Домашнее задание");

int a3 = 20;
int b3 = 70;
int c3 = 8;
int d3 = 9;
double sum3 = (a3 * b3) / (c3 * d3);

Console.WriteLine(sum3);
