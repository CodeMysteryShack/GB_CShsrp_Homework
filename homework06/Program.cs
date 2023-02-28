// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int FindPositive(int[] array)
{
  int count = 0;
  foreach (int item in array)
  {
    if (item > 0) count++;
  }

  return count;
}

void PrintResult(int[] array, int result)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}{(i != array.Length - 1 ? ", " : "")}");
  }

  Console.WriteLine($" -> {result}");
}

Console.Write("Input how much numbers you want to input: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
  Console.Write($"Input number {i + 1}: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
}
PrintResult(array, FindPositive(array));

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// После загрузки задания, вы можете проверить себя самостоятельно с помощью эталонного решения

// double[] FindIntersection(double k1, double b1, double k2, double b2)
// {
//   return new double[] { ((b2 - b1) / (k1 - k2)), (k1 * ((b2 - b1) / (k1 - k2)) + b1) };
// }

// Console.Write("Input k1 coefficient: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input b1 coefficient: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input k2 coefficient: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input b2 coefficient: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2 && b1 != b2)
// {
//   Console.WriteLine($"Lines y = {k1} * x + {b1} and y = {k1} * x + {b1} do not intersect!");
// }
// else
// {
//   Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({Math.Round(FindIntersection(k1, b1, k2, b2)[0], 2)}; {Math.Round(FindIntersection(k1, b1, k2, b2)[1], 2)})");
// }
