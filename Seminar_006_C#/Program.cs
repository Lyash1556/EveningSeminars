﻿// ПЕРЕВОРОТ МАССИВА

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue - 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
            Console.Write(array[i]);
        else
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input namber elemets: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min pussible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max pussible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(m, min, max);

ShowArray(myArray);

ReverseArray(myArray);

ShowArray(myArray);

//Console.Write($"The sum not even numbers of array is: {result}");
*/




//ЗАДАЧА////////////////Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*
bool FindThreeangle(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.Write("Введите a: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c: ");
int c1 = Convert.ToInt32(Console.ReadLine());

bool result = FindThreeangle(a1, b1, c1);
Console.WriteLine(result);
*/


//ЗАДАЧА////////////Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue - 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
            Console.Write(array[i]);
        else
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int[] Fibonachi(int[] array, int first, int second)
{
    array[0] = first;
    array[1] = second;

    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1]; 
    }
    return array;
}

Console.Write("Input namber elemets: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min pussible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max pussible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);

ShowArray(myArray);

Console.Write("Input first namber fibonachi: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second namber fibonachi: ");
int b = Convert.ToInt32(Console.ReadLine());

Fibonachi(myArray, a, b);

ShowArray(myArray);

*/


//ЗАДАЧА////////////////Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue - 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
            Console.Write(array[i]);
        else
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int[] CopyArray(int[] array, int[] newArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i]; 
    }
    return newArray;
}

Console.Write("Input namber elemets: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min pussible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max pussible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
int[] newArray = CreateRandomArray(n, min, max);

ShowArray(myArray);

ShowArray(newArray);

CopyArray(myArray, newArray);

ShowArray(newArray);
*/