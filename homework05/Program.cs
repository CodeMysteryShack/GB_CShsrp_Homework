// ОБЩИЕ ФУНКЦИИ
int[] CreateRandomArray(int size, int min, int max)
{
  int[] array = new int[size];

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(min, max + 1);
  }

  return array;
}

void PrintResult(int[] array, int result)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{(i == 0 ? "[" : "")}{array[i]}{(i == array.Length - 1 ? $"] -> {result}" : ", ")}");
  }
  Console.WriteLine();
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int CountEven(int[] arr)
// {
//   int count = 0;

//   foreach (int item in arr)
//   {
//     if (item % 2 == 0)
//     {
//       count++;
//     }
//   }

//   return count;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, 100, 999);

// PrintResult(array, CountEven(array));

// =====================================================================================

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int SummOfOddElements(int[] array)
// {
//   int summ = 0;

//   for (int i = 0; i < array.Length; i++)
//   {
//     if ((i + 1) % 2 != 0)
//     {
//       summ += array[i];
//     }
//   }

//   return summ;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);

// PrintResult(array, SummOfOddElements(array));

// =====================================================================================

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double GetRandomNumber(double minimum, double maximum)
{
  Random random = new Random();
  return random.NextDouble() * (maximum - minimum) + minimum;
}

double[] CreateRandomDoubleArray(int size, double min, double max)
{
  double[] array = new double[size];

  for (int i = 0; i < size; i++)
  {
    array[i] = GetRandomNumber(min, max);
  }

  return array;
}

double MinMaxDiff(double[] array, bool displayMinMax = true)
{
  double min = array[0];
  double max = array[0];
  foreach (double item in array)
  {
    if (min > item) min = item;
    if (max < item) max = item;
  }

  if (displayMinMax) Console.WriteLine($"min={min} max={max}"); // для проверки выводим min max
  return max - min;
}

void PrintDoubleResult(double[] array, double result, int accuracy = 3)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{(i == 0 ? "[" : "")}{Math.Round(array[i], accuracy)}{(i == array.Length - 1 ? $"] -> {Math.Round(result, accuracy)}" : ", ")}");
  }
  Console.WriteLine();
}


Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value of array element: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input maximal value of array element: ");
double max = Convert.ToDouble(Console.ReadLine());

double[] array = CreateRandomDoubleArray(size, min, max);

PrintDoubleResult(array, MinMaxDiff(array));
