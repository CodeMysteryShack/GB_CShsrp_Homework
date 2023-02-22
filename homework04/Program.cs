// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// вообще, это делается так ;-):
// int NumToPow(int a, int b)
// {
//   return (Math.Pow(a, b));
// }

// double NumToPow(int a, int b)
// {
//   double result = 1;

//   for (int i = 1; i <= Math.Abs(b); i++)
//   {
//     if (b > 0)
//     {
//       result *= a;
//     }
//     else
//     {
//       result /= a;
//     }
//   }

//   return result;
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input power: ");
// int power = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(NumToPow(num, power));

// ====================================================

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// 1-й вариант без строк
// int SummOfDigits(int num)
// {
//   int sum = 0;
//   int power = 0;
//   while (num > Math.Pow(10, power))
//   {
//     sum += Convert.ToInt32(Math.Floor(num % Math.Pow(10, power + 1) / Math.Pow(10, power)));
//     power++;
//   }
//   return sum;
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SummOfDigits(num));

// 2-й вариант через строки

// int SummOfDigits(string num)
// {
//   int summ = 0;

//   for (int i = 0; i < num.Length; i++)
//   {
//     summ += Convert.ToInt32(Convert.ToString(num[i]));
//   }

//   return summ;
// }

// Console.Write("Input number: ");
// string num = Console.ReadLine();
// Console.WriteLine(SummOfDigits(num));

// ====================================================

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateArray(int size, int minValue, int maxValue)
// {
//   int[] array = new int[size];

//   for (int i = 0; i < size; i++)
//   {
//     array[i] = new Random().Next(minValue, maxValue + 1);
//   }

//   return array;
// }

// void PrintArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write($"{(i == 0 ? "[" : "")}{array[i]}{(i != array.Length - 1 ? ", " : "]")}");
//   }

//   Console.WriteLine();
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateArray(size, min, max));
