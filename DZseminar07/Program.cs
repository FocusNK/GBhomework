// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// void PrintArray (double [,] matri)
// {
//     for (int i = 0; i < matri.GetLength(0); i++)
//     {
//         for (int j = 0; j < matri.GetLength(1); j++)
//         {
//             Console.Write("{0,9:F1}", matri[i, j]);
//         }
//     Console.WriteLine();
//     }
// }
// void FillArray (double[,] matr)
// {
//     Random random = new Random();
//     for (int i = 0; i < matr.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = random.NextDouble()*10; //Не смог найти вариант как сделать, чтобы рандом для заполнения массива вещественными числами охватывал ещё и диапазон отрицательных т.к. тут от 1 - 10.
//         }
//     }
// }

// Console.WriteLine("Задайте размер двумерного массива");
// Console.WriteLine("Колон = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Стоблцов = ");
// int b = Convert.ToInt32(Console.ReadLine());
// double [,] matrix  = new double [a,b];

// FillArray(matrix);
// PrintArray(matrix);








// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

// void 
// findnumbers (int [,] matri)
// {
//     int numb = Convert.ToInt32(Console.ReadLine());
//     for (int i = 0; i < matri.GetLength(0); i++)
//     {
//         for (int j = 0; j < matri.GetLength(1); j++)
//         {
//             if (matri[i,j] == numb)
//             {
//             Console.WriteLine("Число найдено"); 
//             }
//             else Console.WriteLine("такого числа нет");
//         }
//     Console.WriteLine();
//     }
// }

// void printArray (int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//     Console.WriteLine();
//     }
// }

// int [ , ] array = new int[3, 4]{ {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4} };
// printArray(array);
// findnumbers(array);





// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// void PrintArray (int [,] matri)
// {
//     for (int i = 0; i < matri.GetLength(0); i++)
//     {
//         for (int j = 0; j < matri.GetLength(1); j++)
//         {
//             Console.Write($"{matri[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }
// void FillArray (int[,] matr)
// {
//     for (int i= 0; i < matr.GetLength(0); i++)
//     {
//         for (int j= 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 9);
//         }
//     }
// }
// void SummArray (int[,] mat)
// {
//     double sum = 0;
//     double count = 0;
//     double mid = 0;

//     for (int j = 0; j < mat.GetLength(0); j++)
//     {
//         for (int i= 0; i < mat.GetLength(1); i++)
//         {
//             sum = mat[j,i] + sum;
//             count++;
//         }
//         mid = sum / count;
//         Console.Write(mid + " ");
//     }
// }

// Console.WriteLine("Введите количество элементов n=");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int [,] matrix  = new int[a,b];
// FillArray(matrix);
// PrintArray(matrix);
// SummArray(matrix);