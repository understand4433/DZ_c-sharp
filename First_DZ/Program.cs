﻿// Напишите программу на с#, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Это не трехзначное число");
}
else
{

    int secondDigit = (number / 10) % 10;
    Console.WriteLine("Вторая цифра числа: " + secondDigit);
}