﻿// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 ^ a == 7)
{
    Console.WriteLine("Ура, сегодня выходной!");
}
else
{
    Console.WriteLine("Иди Работай)))");
}