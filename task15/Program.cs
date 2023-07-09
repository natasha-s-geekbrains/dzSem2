﻿// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.Write ("Введите цифру, обозначающую день недели, где 1 - это понедельник: ");
int dayNum = int.Parse(Console.ReadLine());

Console.WriteLine("Номер дня недели - " + dayNum);

if (dayNum > 7 || dayNum < 1)
{
    Console.Write("Дня недели с таким номером не существует.");
}
else if (dayNum > 5)
{
    Console.Write("Это выходной.");
}
else
{
    Console.Write("Это не выходной");
}

