﻿
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Число: ");
int v = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра введенного Вами числа: {(v%100)/10}");
