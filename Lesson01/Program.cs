/*
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/
//Решение Задача1
/*
Console.Write("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целого числа: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if(value1 > value2)
{
    Console.Write("число : ");
    Console.Write(value1);
    Console.Write(" Больше!");
}

if(value2 > value1)
{
    Console.Write("число : ");
    Console.Write(value2);
    Console.Write(" Больше!");
}
*/


/*
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

//Решение Задача2
/*
Console.WriteLine("Приветстсвую!");
Console.Write("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int value3 = Convert.ToInt32(Console.ReadLine());

if(value1 > value2)
{
    if(value1 > value3)
    {
        Console.Write(value1);
    }
}

if(value2 > value1)
{
    if(value2 > value3)
    {
        Console.Write(value2);
    }
}

if(value3 > value2)
{
    if(value3 > value1)
    {
        Console.Write(value3);
    }
}
*/


/*
Задача 3: Напишите программу, которая на вход принимает число и 
выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

//Решение Задача3
/*
Console.WriteLine("Приветстсвую!");
Console.Write("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
if(value1%2 == 0)
{
    Console.Write("четное");
}
else
{
    Console.Write("нечетное");
}
*/

/*
Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5  -> 2, 4
8  -> 2, 4, 6, 8
*/

//Решение Задача4
/*
Console.WriteLine("Привет!");
Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 2;


while(x <= n)
{
    Console.Write(x + " ");
    x+=2;
}
*/

