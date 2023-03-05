// ОБЩИЕ ФУНКЦИИ

void Print2DArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($" {matr[i, j]} ");
    }
    Console.WriteLine();
  }
}

void Print2DRealArray(double[,] matr, int accuracy = 1)
{
  // делаем аккуратный вывод чисeл
  double RoundNum(double num) { return Math.Round(num, accuracy); }
  double AbsNum(double num) { return Math.Abs(RoundNum(num)); }

  int maxNumLength = Convert.ToString(AbsNum(matr[0, 0])).Length;

  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (maxNumLength < Convert.ToString(AbsNum(matr[i, j])).Length)
      {
        maxNumLength = Convert.ToString(AbsNum(matr[i, j])).Length;
      }
    }
  }

  string NumToString(double num)
  {
    return $"{(num >= 0 ? " " : "")}{num}{new string(Convert.ToChar(" "), maxNumLength - Convert.ToString(Math.Abs(num)).Length + 2)}";
  }

  // непосредственно вывод
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write(NumToString(RoundNum(matr[i, j])));
    }
    Console.WriteLine();
  }
}

void Fill2DArray(int[,] matr, int min = 1, int max = 10)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(min, max + 1);
    }
  }
}

double GetRandomDoubleNumber(double minimum, double maximum)
{
  Random random = new Random();
  return random.NextDouble() * (maximum - minimum) + minimum;
}

// =============================================================

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// void Fill2DRealArray(double[,] matr, double min, double max)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       matr[i, j] = GetRandomDoubleNumber(min, max);
//     }
//   }
// }

// Console.Write("Input number of rows in array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in array: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min value: ");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input max value: ");
// double max = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input accuracy: ");
// int accuracy = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m, n];
// Fill2DRealArray(array, min, max);
// Print2DRealArray(array, accuracy);

// =============================================================

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// void FindElementInArray(int[,] arr, int row, int col)
// {
//   if (row < 0 || row > arr.GetLength(0) - 1 || col < 0 || col > arr.GetLength(1) - 1)
//   {
//     Console.WriteLine($"There is no element [{row}, {col}] in array");
//   }
//   else
//   {
//     Console.WriteLine($"Element [{row}, {col}] is {arr[row, col]}");
//   }
// }

// Console.Write("Input number of rows in array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// Fill2DArray(array);

// Console.Write("Input number of row to find: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of column to find: ");
// int col = Convert.ToInt32(Console.ReadLine());

// Print2DArray(array);
// FindElementInArray(array, row, col);

// =============================================================

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// double[] GetAverageOfColumn(int[,] arr)
// {
//   double[] result = new double[arr.GetLength(1)];

//   for (int j = 0; j < arr.GetLength(1); j++)
//   {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//       result[j] += arr[i, j];
//     }
//     result[j] /= arr.GetLength(0);
//   }

//   return result;
// }

// void PrintResult(double[] arr, int accuracy = 1)
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     Console.Write($"{Math.Round(arr[i], accuracy)}{(i != arr.Length - 1 ? "; " : "")}");
//   }

//   Console.WriteLine();
// }

// Console.Write("Input number of rows in array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// Fill2DArray(array);
// Print2DArray(array);
// PrintResult(GetAverageOfColumn(array));
