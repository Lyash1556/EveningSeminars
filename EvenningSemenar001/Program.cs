﻿// семинар 1


//
// задача 1. Является ли первое число квадратом второго.
//


/*
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
*/


//
//Задача 2. Программа на вход принимает одно число N, а на выходе показывает все целые числа от -N до N.
//



/*
Console.Write("input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

while(current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/



//МЕТОДЫ и Функции


//
//Задача 1. Берет случайное трех значное число и вырезает у него вторую цифру
//


/*
int CutNumber(int num)
{
    int sot = num / 100;
    int ed = num % 10;

    int result = sot * 10 + ed;
    return result;
}

int randNum =  new Random().Next(100, 1000);

int newNum = CutNumber(randNum);



Console.WriteLine($"Случайное счисло {randNum}, итоговое число {newNum}");
*/

//Составные условия
/*
if(newNum > 0 && newNum % 2 == 0);  // и

if(newNum > 0 || newNum % 2 == 0);  // или
*/


// да нет
/*
bool

return true;
*/


//
// задача Выводит случайное число от 10 до 99 всл и показывает наибольшую цифру числа.
//


/*
int MaxNumber(int num)
{
    int first = num / 10;
    int second = num % 10;

    if(first > second) return(first);
    else return second;
}

int randNumber = new Random().Next(10, 100);

int maxNumber = MaxNumber(randNumber);

Console.WriteLine($"В случайном двузначном числе {randNumber} максимальная цифра это {maxNumber}");
*/


//
// задача Принимает на вход 2 числа и выводить является ли второе число кратным первому  
//


/*
bool CheckDiv(int num1, int num2)
{
    if(num1 % num2 == 0) return true;
    else return false;
}   

Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

bool result = CheckDiv(x, y);
Console.WriteLine(result);
*/



//
// задача принимает на вход число и проверяет кратно ли оно одновременно a и b.
//


bool Check(int num, int num1, int num2)
{
    if(num1 % num == 0 && num2 % num == 0) return true;
    else return false;
}

Console.WriteLine("Введите проверяемое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

bool result = Check(n, a, b);

Console.WriteLine(result);