﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int dayNumber = int.Parse(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Это выходной день.");
}
else
{
    Console.WriteLine("Это не выходной день.");
}