﻿// задача №5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

System.Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine()); //4
int numberNegative = -number; // -4
while(numberNegative <= number)
{
    System.Console.Write($"{numberNegative} ");
    numberNegative++;
}