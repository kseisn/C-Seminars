// Задача 1. Напишите программу, запрашивающую целое число у пользователя,
//           а после выдает квадрат этого числа.

// Console.WriteLine("Input number");
// int a = Convert.ToInt32(Console.ReadLine());

// Первый вариант:
// int b = a * a;
// Console.WriteLine($"This is the square of your number -> {b}");
// Второй вариант:
// Console.WriteLine($"Quad of {a} -> {a * a}");

//Задача 2. Напишите программу, которая на вход принимает два числа и
//          проверяет, является ли первое число квадратом второго.

// Console.Write("Input first number a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number b = ");
// int b = Convert.ToInt32(Console.ReadLine());
// if(b * b == a) Console.WriteLine($"The number {a} is a square of the number {b}");
// else Console.WriteLine($"The number {a} is not a square of the number {b}");
 
// Задача 3. Напишите программу, которая на вход принимает одно число (N),
//           а на выходе показывает все целые числа в промежутке от -N до N.
//           4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//           2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Input number N");
// int n = Convert.ToInt32(Console.ReadLine());
// int p = n * (-1);
// while (p <= n)
// {
//     Console.Write(p + " ");
//     p ++;
// }

// Задача 4. Напишите программу, которая принимает на вход трёхзначное число
//           и на выходе показывает **последнюю** цифру этого числа.
//           456 -> 6
//           782 -> 2
//           918 -> 8

// Console.WriteLine("Input three digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// int p;
// if (num >= 100 && num <= 999)
// {
//     p = num % 10;
//     Console.WriteLine($"Last digit of {num} -> {p}");
// }
// else
// {
//     Console.WriteLine("You are wrong!");
// }

