// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите количество элементов n=");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array  = new int [n];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if(array[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine(count + " Положительных чисел ввел пользователь");





// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

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
//             matr[i,j] = 1;
//         }
//     }
//     for (int i= 1; i < matr.GetLength(0) - 1; i++)
//     {
//         for (int j= 1; j < matr.GetLength(1) - 1; j++)
//         {
//             matr[i,j] = 0;
//         }
//     }
// }

// Console.WriteLine("Введите количество элементов n=");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int [,] matrix  = new int[a,b];
// FillArray(matrix);
// PrintArray(matrix);