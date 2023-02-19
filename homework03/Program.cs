// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// 1-вариант. Без строк
// using System;
// using System.Text.RegularExpressions; // в общем случае, использовал только, чтобы проверить, является ли полученное из терминала 5-значным числом

// bool isPalindrome(int num)
// {
//   return (num % 10 == num / 10_000) && (num % 100 / 10 == num % 10_000 / 1000);
// }

// Console.Write("Input 5-digit number: ");
// string num = Console.ReadLine();

// if (!Regex.IsMatch(num.Trim(), @"^\d{5}$"))
// {
//   Console.WriteLine("This is not 5-digit number");
// }
// else
// {
//   Console.WriteLine(isPalindrome(Convert.ToInt32(num)) ? $"{num} is a Palindrome" : $"{num} is not a Palindrome");
// }

// 2-й вариант. Через строки, работает для числа с любым кол-вом цифр
// using System;
// using System.Text.RegularExpressions; // в общем случае, использовал только, чтобы проверить, является ли полученное из терминала 5-значным числом

// bool isPalindrome(string num)
// {
//   bool rez = true;

//   for (int i = 0; i < num.Length / 2; i++)
//   {
//     if (num[i] != num[num.Length - 1 - i])
//     {
//       rez = false;
//       break;
//     }
//   }
//   return rez;
// }

// Console.Write("Input 5-digit number: ");
// string num = Console.ReadLine();

// if (!Regex.IsMatch(num.Trim(), @"^\d+$"))
// {
//   Console.WriteLine("This is not а number");
// }
// else
// {
//   Console.WriteLine(isPalindrome(num) ? $"{num} is a Palindrome" : $"{num} is not a Palindrome");
// }

// 3-й вариант — универсальный, для числа с любым кол-вом цифр и без строк

// using System;
// using System.Text.RegularExpressions; // в общем случае, использовал только, чтобы проверить, является ли полученное из терминала 5-значным числом

// int FindPower(int num) // находим кол-во цифр в числе
// {
//   int power = 1;
//   while (num > Math.Pow(10, power))
//   {
//     power++;
//   }
//   return power;
// }

// bool isPalindrome(int num)
// {
//   int power = FindPower(num);
//   bool result = true;

//   for (int counter = 1; counter < power / 2; counter++)
//   {
//     if (Math.Round(num % Math.Pow(10, counter) / Math.Pow(10, counter - 1)) != Math.Round(num / Math.Pow(10, power - counter)) % 10)
//     {
//       result = false;
//       break;
//     }
//   }
//   return result;
// }

// Console.Write("Input 5-digit number: ");
// string num = Console.ReadLine();

// if (!Regex.IsMatch(num.Trim(), @"^\d{5}$"))
// {
//   Console.WriteLine("This is not 5-digit number");
// }
// else
// {
//   Console.WriteLine(isPalindrome(Convert.ToInt32(num)) ? $"{num} is a Palindrome" : $"{num} is not a Palindrome");
// }

// ==========================================================

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance3d(double x1, double y1, double z1, double x2, double y2, double z2, int accuracy = 3)
// {
//   return Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)), accuracy);
// }


// Console.Write("Input X1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input Y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input Z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input X2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input Y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input Z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point1 ({x1}, {y1}, {z1}) and point2 ({x2}, {y2}, {z2}): {FindDistance3d(x1, y1, z1, x2, y2, z2)}");


// ==========================================================

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// 1-й вариант ф-ция просто выводит строку

// void CubesChain(int num)
// {
//   Console.Write($"{num} -> ");

//   for (int i = 1; i <= num; i++)
//   {
//     Console.Write($"{Math.Pow(i, 3)}{(i != num ? ", " : "")}");
//   }
//   Console.WriteLine();
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// CubesChain(n);

// 2-й вариант ф-ция возвращает массив, что более переиспользуемо + разнесёны получение ряда чисел и вывод

// int[] CubesChain(int num)
// {
//   int[] arr = new int[num];

//   for (int i = 0; i < num; i++)
//   {
//     arr[i] = Convert.ToInt32(Math.Pow((i + 1), 3)); // тут ругался error CS0266: Не удается неявно преобразовать тип "double" в "int". Существует явное преобразование (возможно, пропущено приведение типов). Пришлось добавить Convert.ToInt32()
//   }
//   return arr;
// }

// void OutputCubesChain(int[] arr)
// {
//   Console.Write($"{arr.Length} -> ");

//   for (int i = 0; i < arr.Length; i++)
//   {
//     Console.Write($"{arr[i]}{(i != arr.Length - 1 ? ", " : "")}");
//   }
//   Console.WriteLine();
// }


// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// OutputCubesChain(CubesChain(n));
