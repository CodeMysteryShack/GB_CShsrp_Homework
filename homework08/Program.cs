// ОБЩИЕ ФУНКЦИИ

int[,] Create2DRandomArray(int rows, int columns, int minValue = 1, int maxValue = 10)
{
  int[,] newArray = new int[rows, columns];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }

  return newArray;
}

int[] CreateRandomArray(int length, int minValue = 1, int maxValue = 10)
{
  int[] newArray = new int[length];

  for (int i = 0; i < length; i++)
  {
    newArray[i] = new Random().Next(minValue, maxValue + 1);
  }

  return newArray;
}


void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{(i == 0 ? "[" : "")}{array[i]}{(i == array.Length - 1 ? $"]" : ", ")}");
  }
  Console.WriteLine();
}

void Show2DArray(int[,] array)
{
  // делаем аккуратный вывод чисeл
  int AbsNum(int num) { return Math.Abs(num); }

  int maxNumLength = Convert.ToString(AbsNum(array[0, 0])).Length;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (maxNumLength < Convert.ToString(AbsNum(array[i, j])).Length)
      {
        maxNumLength = Convert.ToString(AbsNum(array[i, j])).Length;
      }
    }
  }

  string NumToString(int num)
  {
    return $"{(num >= 0 ? " " : "")}{num}{new string(Convert.ToChar(" "), maxNumLength - Convert.ToString(Math.Abs(num)).Length + 2)}";
  }

  // непосредственно вывод
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(NumToString(array[i, j]));
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] SortRowsInArrayByDescending(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int k = array.GetLength(1); k > 0; k--)
//     {
//       for (int j = 1; j < k; j++)
//       {
//         if (array[i, j - 1] < array[i, j])
//         {
//           int temp = array[i, j - 1];
//           array[i, j - 1] = array[i, j];
//           array[i, j] = temp;
//         }
//       }
//     }
//   }
//   return array;
// }

// Console.Write("Input number of rows in array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(m, n);
// Show2DArray(array);
// Show2DArray(SortRowsInArrayByDescending(array));

// ======================================================================================================

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int FindMinimalSummRow(int[,] array)
// {
//   int[] SummOfElementsInRow = new int[array.GetLength(0)];

//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       SummOfElementsInRow[i] += array[i, j];
//     }
//   }

//   // на всякий случай выводим массив с суммами элементов
//   PrintArray(SummOfElementsInRow);

//   int minSummRow = 0;

//   for (int i = 1; i < SummOfElementsInRow.Length; i++)
//   {
//     if (SummOfElementsInRow[i] < SummOfElementsInRow[minSummRow])
//     {
//       minSummRow = i;
//     }
//   }

//   return minSummRow;
// }

// Console.Write("Input number of rows in array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in array: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(m, n, min, max);
// Show2DArray(array);

// Console.WriteLine($"Index of the row with minimal summ of elements: {FindMinimalSummRow(array)}");

// ======================================================================================================

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] MatrixMultiply(int[,] matr1, int[,] matr2)
// {
//   int[,] resultMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       for (int k = 0; k < matr1.GetLength(1); k++)
//       {
//         resultMatrix[i, j] += matr1[i, k] * matr2[k, j];
//       }
//     }
//   }

//   return resultMatrix;
// }

// Console.Write("Input number of rows in 1st array: ");
// int l = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in 1st array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in 2st array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matr1 = Create2DRandomArray(l, m, 1, 9);
// int[,] matr2 = Create2DRandomArray(m, n, 1, 9);

// Console.WriteLine($"Matix 1 ({l}x{m}):");
// Show2DArray(matr1);
// Console.WriteLine($"Matix 2 ({m}x{n}):");
// Show2DArray(matr2);
// Console.WriteLine($"Result of Matrix 1 and Matrix 2 calculation ({l}x{n}):");
// Show2DArray(MatrixMultiply(matr1, matr2));

// ======================================================================================================

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// проверяем есть ли уже сгенерированный элемент в массиве
// bool IsSameElementBeforeIn3DArray(int[,,] array, int elementRow, int elementCol, int elementVert)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     if (i < elementRow)
//     {
//     }
//     for (int j = 0; j < array.GetLength(2); j++)
//     {
//       if (i != elementRow && j != elementCol)
//       {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//           if (array[i, j, k] == array[elementRow, elementCol, elementVert])
//           {
//             return true;
//           }
//         }
//       }
//       else
//       {
//         for (int k = 0; k < elementVert; k++)
//         {
//           if (array[i, j, k] == array[elementRow, elementCol, elementVert])
//           {
//             return true;
//           }
//         }
//       }
//     }
//   }
//   return false;
// }

// int[,,] Create3DRandomArray(int rows, int columns, int verticals, int minValue = 10, int maxValue = 99)
// {
//   int[,,] newArray = new int[rows, columns, verticals];

//   for (int i = 0; i < newArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < newArray.GetLength(1); j++)
//     {
//       for (int k = 0; k < newArray.GetLength(2); k++)
//       {
//         newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
//         while (IsSameElementBeforeIn3DArray(newArray, i, j, k))
//         {
//           newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
//         }
//       }
//     }
//   }
//   return newArray;
// }

// void Print3DArray(int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         Console.Write($"{array[i, j, k]} ({i},{j},{k}){(k != array.GetLength(2) - 1 ? "   " : "")}");
//       }
//       Console.WriteLine();
//     }
//   }
// }

// Console.Write("Input number of rows in array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in array: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of verticals in array: ");
// int k = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(m, n, k);
// Print3DArray(myArray);

// ======================================================================================================

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] CreateSpiralMatrix(int size)
// {
//   int[,] matrix = new int[size, size];

//   if (size == 1)
//   {
//     matrix[0, 0] = 1;
//   }
//   else
//   {
//     for (int i = 1; i <= size; i++)
//     {
//       for (int j = 1; j <= size; j++)
//       {
//         int switcher = (j - i + size) / size;
//         int iCenter = Math.Abs(i - Convert.ToInt32(size / 2) - 1) + (i - 1) / Convert.ToInt32(size / 2) * ((size - 1) % 2);
//         int jCenter = Math.Abs(j - Convert.ToInt32(size / 2) - 1) + (j - 1) / Convert.ToInt32(size / 2) * ((size - 1) % 2);
//         int ring = size / 2 - (Math.Abs(iCenter - jCenter) + iCenter + jCenter) / 2;
//         int xs = i - ring + j - ring - 1;
//         int coef = 4 * ring * (size - ring);
//         matrix[i - 1, j - 1] = coef + switcher * xs + Math.Abs(switcher - 1) * (4 * (size - 2 * ring) - 2 - xs);
//       }
//     }
//   }

//   return matrix;
// }

// string NumToString(int num, int size)
// {
//   int power = (Math.Pow(size, 2)).ToString().Length;
//   int numPower = num.ToString().Length;
//   return $"{(power > numPower ? new string(Convert.ToChar("0"), power - numPower) : "")}{num}  ";
// }

// void PrintSpiralMatrix(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       Console.Write(NumToString(matr[i, j], matr.GetLength(0)));
//     }
//     Console.WriteLine();
//   }
// }

// Console.Write("Input number of rows and columns in array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// PrintSpiralMatrix(CreateSpiralMatrix(size));
