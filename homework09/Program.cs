// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNaturalNumbers(int n)
// {
//   if (n > 0)
//   {
//     Console.Write($"{n}{(n != 1 ? ", " : "")}");
//     PrintNaturalNumbers(n - 1);
//   }
// }

// Console.Write("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"N = {n} -> \"");
// PrintNaturalNumbers(n);
// Console.WriteLine("\"");

// ========================================================================================================================

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SummOfNumbersInDiapason(int m, int n)
// {
//   if (m < n)
//   {
//     if (m < n)
//     {
//       return SummOfNumbersInDiapason(m + 1, n) + m;
//     }
//   }
//   else if (m > n)
//   {
//     if (m > n)
//     {
//       return SummOfNumbersInDiapason(m, n + 1) + n;
//     }
//   }
//   return n;
// }

// Console.Write("Input number m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"M = {m}; N = {n} -> {SummOfNumbersInDiapason(m, n)}");

// ========================================================================================================================

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AkkermanFunction(int m, int n)
// {
//   if (m == 0)
//   {
//     return n + 1;
//   }
//   else if ((m > 0) && (n == 0))
//   {
//     return AkkermanFunction(m - 1, 1);
//   }
//   else
//   {
//     return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//   }
// }

// Console.Write("Input number m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"M = {m}; N = {n} -> {AkkermanFunction(m, n)}");
