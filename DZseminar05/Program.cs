// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] mass = new int[10];
// int count = 0;
// Console.Write("[");
// for(int i = 0; i < 12; i++)
// {
//     mass[i] = new Random().Next(100,1000);
//     Console.Write(" " + mass[i] + ",");
//     if(mass[i] % 2 == 0)
//     {

//         count++;
//     }    
// }
// Console.WriteLine(" ]");
// Console.WriteLine(" Четных чисел в массиве найдено:  "+ count);


// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] mass = new int[10];
// int summ = 0;
// for(int i = 0; i < mass.Length; i++)
// {
//     mass[i] = new Random().Next(10,100);
//     Console.Write(" " + mass[i]);
//     for(int j = 0; j < 10; j = j + 2)
//     {
//         summ = summ + mass[i];
//     }
// }
// Console.WriteLine(summ);


// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// Console.WriteLine("Введите количество элементов n=");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array  = new double[n];
// double result = 0;

// double maxB = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 9);
//     Console.Write(array[i] + " ");
//     if (array[i] > maxB)
//     {
//         maxB = array[i];
//     }    
// }
// double minA = array[0];
// for (int j = 0; j< array.Length; j++)
// {
//     if (minA > array[j])
//     {
//         minA = array[j];
//     }
// }
// result = maxB - minA;

// Console.WriteLine(" ");   
// Console.WriteLine(result + " Разница ");   
