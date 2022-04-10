// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int CycleNumberToThePower (int num, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result *= num; 
    }
    return result;
}

Console.WriteLine("Введите два числа (A и B) для возведения числа A в натуральную степень B.");
Console.WriteLine("Число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Степень В: ");
int power = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( CycleNumberToThePower (number, power));
*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int result = 0;
while (num>0)
{
    i =  num%10;
    num = num/10;
    result = result + i;   
}

Console.WriteLine(result);
*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.WriteLine("Введите кол-во эл. массива");
// int elementMassive = int.Parse(Console.ReadLine());
// int[] myArray = new int[elementMassive];

// for(int i = 0; i < myArray.Length; i++)
// {
//     Console.Write($"Введите элемент массива под индексом {i}:\t ");
//     myArray[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Вывод массива: ");

// for(int i = 0; i < myArray.Length; i++)
// {
//     Console.WriteLine(myArray[i]);
// }
// Console.ReadLine();
