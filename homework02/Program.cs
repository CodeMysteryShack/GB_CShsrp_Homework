// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigit(int num)
// {
//   return num % 100 / 10;
// }

// Console.Write($"Enter 3-digit number: ");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//   Console.WriteLine($"Second digit in {number} is {SecondDigit(number)}");
// }
// else
// {
//   Console.WriteLine($"Number has more or less 3 digits");
// }



// ===============================================================================================================
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// using System;
// using System.Text.RegularExpressions;

// void ThirdDigit(string num)
// {
//   if (!Regex.IsMatch(num, @"^\d+$"))
//   {
//     Console.WriteLine($"{num} is not a number");
//   }
//   else if (num.Length < 3)
//   {
//     Console.WriteLine($"There is no 3d digit number {num}");
//   }
//   else
//   {
//     Console.WriteLine($"Third digit in number {num} is: {num[2]}");
//   }
// }

// Console.Write($"Enter number: ");

// string number = Console.ReadLine();

// ThirdDigit(number);

// ===============================================================================================================

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// bool IsDayOff(int num)
// {
//   return num % 7 == 6 || num % 7 == 0;
// }

// Console.Write($"Enter number of the day: ");

// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(IsDayOff(number) ? "да" : "нет");
