// Напишите программу, которая на вход принимает число и кидает его квадрат (число умноженное
// на само себя).

// Напиример:
// 4 -> 16
// -3 -> 9
// -7 -> 49 ctrl + /

using System.Linq.Expressions;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // "5" -> 5
int square = number * number;
Console.WriteLine($"Квадрат числа {number} => {square}");

