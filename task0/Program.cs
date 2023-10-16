// Задача №1. Напишите программу , которая на вход принимает два числа и проверяет, являетс ли первое число квадратом второго.
// a = 26, b = 5 -> да
// a = 2, b= 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b= 19 -> нет

System.Console.WriteLine("Введите два числа: ");
int x = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int square = b*b;
if (square == x)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else
{
    System.Console.WriteLine("Не является");
}