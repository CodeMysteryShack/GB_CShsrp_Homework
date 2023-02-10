// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// =================================================================================================

// Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());

// string msg = "";

// if (a > b)
// {
//   msg = $"max = {a}, so first number ({a}) is greater than second number ({b})";
// }
// else
// {
//   msg = $"max = {b}, so second number ({b}) is greater than first number ({a})";
// }

// Console.WriteLine(msg);

// =================================================================================================
// =================================================================================================
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// =================================================================================================

// int[] arr = new int[3];

// Console.Write("Input first number: ");
// arr[0] = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// arr[1] = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// arr[2] = Convert.ToInt32(Console.ReadLine());

// int max = arr[0];

// for (int i = 0; i < arr.Length; i++)
// {
//   if (arr[i] > max)
//   {
//     max = arr[i];
//   }
// }

// Console.WriteLine($"The biggest number is {max}");


// =================================================================================================
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string msg = "";

// if (num % 2 == 0)
// {
//   msg = $"Your number ({num}) is even"; // число чётное
// }
// else
// {
//   msg = $"Your number ({num}) is odd (not even)"; // число нечётное
// }

// Console.WriteLine(msg);

// =================================================================================================
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Input your number: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while (count < N)
// {
//   if (count % 2 == 0)
//   {
//     Console.Write(count + " ");
//   }
//   count++;
// }

// Console.WriteLine(""); // только, чтобы перевести строку в консоли без дополнительных условий
