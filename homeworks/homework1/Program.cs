﻿// Задача 2: Напишите программу, которая на вход принимает два числа
//           и выдаёт, какое число большее, а какое меньшее.
//           a = 5; b = 7 -> max = 7
//           a = 2; b = 10 -> max = 10
//           a = -9; b = -3 -> max = -3

// Console.Write("Input first number a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number b = ");
// int b = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if(max > b) Console.WriteLine($"max = {a}, min = {b}");
// else Console.WriteLine($"max = {b}, min = {a}");

// Задача 4: Напишите программу, которая принимает на вход три числа
//           и выдаёт максимальное из этих чисел.
//           2, 3, 7 -> max = 7
//           44, 5, 78 -> max = 78
//           22, 3, 9 -> max = 22

// Console.Write("Input first number a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number b = ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number c = ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.WriteLine($"Max number is {max}");

// Задача 6: Напишите программу, которая на вход принимает число
//           и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//           4 -> да
//           -3 -> нет
//           7 -> нет

// Console.Write("Input number a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0) Console.WriteLine($"The number {a} is an even number");
// else Console.WriteLine($"The number {a} is not an even number");

// Задача 8: Напишите программу, которая на вход принимает число (N),
//           а на выходе показывает все чётные числа от 1 до N.
//           5 -> 2, 4
//           8 -> 2, 4, 6, 8

Console.Write("Input number N = ");
int n = Convert.ToInt32(Console.ReadLine());
int p = 1;
while (p <= n)
{
    if (p % 2 == 0)
    {
        Console.Write(p + " ");
        p++;
    }
    p++;
}