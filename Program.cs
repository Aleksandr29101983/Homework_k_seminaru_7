//                                  ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 7

//Math.Round(Random().NextDouble(), 2);
 
//  // ЗАДАЧА 47. Задайте двуменый массив размером m x n, заполненный случайными вещественными числами

// double [,] FullTwoArray(int m, int n)
// {
//     double [,] twoArray = new double [m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             twoArray [i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 1);
//         }
//     }
//     return twoArray;
// }

// void PrintArray(double [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,5}", array[i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }

// }

// Console.Write("Enter the number of rows in the array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the numberu of columns in the array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// PrintArray(FullTwoArray(m, n));

// // ЗАДАЧА 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// //            и возвращает значение этого элемента или же указание, что такого элемента нет

// int [,] FullTwoArray (int m, int n)
// {
//     int [,] twoArray = new int [m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//             {
//                 twoArray [i, j] = new Random().Next(0, 10);
//             }
//     }
//     return twoArray;
// }

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0, 3}", array[i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// Console.WriteLine("The resulting array:");
// int [,] newTwoArray = FullTwoArray(10, 10);
// PrintTwoArray(newTwoArray);

// Console.Write("Enter the row number of the array, starting from zero: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the column number of the array, starting from zero: ");
// int column = Convert.ToInt32(Console.ReadLine());

// if(row < newTwoArray.GetLength(0) & column < newTwoArray.GetLength(1))
// {
//     Console.WriteLine($"The element of the array with the specified coordinates [{row}, {column}] is equal to: {newTwoArray[row, column]}");
// }
// else Console.WriteLine($"The array element with the specified coordinates [{row}, {column}] not exist");

// // ЗАДАЧА  52. Задайте двумерный массив из целых чисел. 
// //             Найдите среднее арифметическое элементов в каждом столбце

// int [,] FullTwoArray(int m, int n)
// {
//     int [,] twoArray = new int [m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             twoArray [i, j] = new Random().Next(0, 10);
//         }
//     }
//     return twoArray;
// }

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//         Console.Write("{0, 4}", array[i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// void SumElementsColumn(int [,] array)
// {
//     double result = 0;
//     for(int i = 0; i < array.GetLength(1); i++)
//     {
//         for(int j = 0; j < array.GetLength(0); j++)
//         {
//             result += array [j, i];
//         }
//         Console.Write("{0, 4}", Math.Round(result/array.GetLength(0), 1) + "|");
//         result = 0;
//     }
//     Console.WriteLine("\b.");
// }

// int [,] twoArray = FullTwoArray(3, 5);
// Console.WriteLine("The resulting array:");
// PrintTwoArray(twoArray);

// Console.WriteLine("The arithmetic averages of the elements of each column of the array are equal to:");
// SumElementsColumn(twoArray);











//                                         ЗАДАЧИ СЕМИНАРА 7

// ЗАДАЧА 1. Задайте двумерный массив размером m x n, заполненный случайными целыми числами.
//           m = 3, n = 4

// int [,] FullTwoArray(int m, int n)
// {
//     int [,] twoArray = new int [m, n];
//     for(int i = 0; i < twoArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < twoArray.GetLength(1); j++)
//         {
//             twoArray[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return twoArray;
// }

// void PrintTwoArray(int [,] twoArray)
// {
//     for(int i = 0; i < twoArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < twoArray.GetLength(1); j++)
//         {
//             Console.Write(twoArray[i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }
// PrintTwoArray(FullTwoArray(3, 4));

// int [,] Create2dArray()
// {
//     Console.Write("intput numbers of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of colum: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int [,]createdArray = new int [rows, columns];
    
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             createdArray [i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return createdArray;
// }

// void PrintTwoArray (int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "|");
//         }
//         Console.WriteLine();
//     }
// }

// //int [,] newArray = Create2dArray();
// //PrintTwoArray(newArray);
// PrintTwoArray(Create2dArray());

// // ЗАДАЧА 2. Задайте двумерный массив размера m x n, 
// //           каждый элемент в массиве находится по формуле: Amn = m + n. 
// //           Выведите на экран полученный массив

// int [,] FullTwoArray (int m, int n)
// {
//     int [,] twoArray = new int [m, n];
//     for(int i = 0; i < twoArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < twoArray.GetLength(1); j++)
//         {
//             twoArray [i, j] = i + j;
//         }
//     }
//     return twoArray;
// }

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// PrintTwoArray(FullTwoArray(10000, 0));


// ЗАДАЧА 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
//           и замените эти элементы на их квадраты

// int [,] FullTwoArray(int a, int b)
// {
//     int [,] twoArray = new int[a, b];
//     for(int i = 0; i < a; i++)
//     {
//         for(int j = 0; j < b; j++)
//         {
//             twoArray[i, j] = new Random().Next(2, 3);
//         }
//     }
//     return twoArray;
// }

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// int [,] QuadrElementsArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++) // либо i += 2
//     {
//         for(int j = 0; j < array.GetLength(1); j++) // либо j += 2
//         {
//             if(i % 2 == 0 & j % 2 == 0) array[i, j] *= array[i, j]; // соответственно array[i, j] *= array[i, j] без if
//         }
//     }
//     return array;
// }

// int [,] newArray = FullTwoArray(10, 10);
// Console.WriteLine("The original array:");
// PrintTwoArray(newArray);

// Console.WriteLine("The converted array:");
// PrintTwoArray(QuadrElementsArray(newArray));