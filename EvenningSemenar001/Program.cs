﻿// семинар 1
// задача 1. Является ли первое число квадратом второго.

Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if(num1 == quad)
{
    Console.Write("yes");
}
else
{
    Console.Write("No");
}