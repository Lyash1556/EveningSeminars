//arrays

//Задать массив из 12 элем заполненный случайными числами от -9 до 9. 
//найдите сумму отрицательных элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}

int GetSumOfNegative(int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sum += array[i];
        }
    }
}

Console.Write("Input namber elemets: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min pussible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max pussible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);















int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}

Console.Write("Input namber elemets: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min pussible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max pussible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
























//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
Console.WriteLine("The program for find the power of number.");
int FindPower(int number, int power)
{
    int res = 1;
    for (int i = 1; i <= power; i++)
    {
        res = number * res;
    }
    return res;
}
Console.Write("Input an any number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the power: ");
int pow = Convert.ToInt32(Console.ReadLine());
int result = FindPower(num, pow);
Console.Write($"The number {num} to the {pow} power is: {result}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.WriteLine("The program for find the sum of the numbers in an any number.");
int FindSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        int current = number % 10;
        sum = sum + current;
        number = number / 10;   
    }
    return sum;
}
Console.Write("Input an any number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = FindSum(num);
Console.Write($"The sum of the numbers in your any number is: {result}");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
Console.WriteLine("The program for create an array of N elements.");
int[] CreateUserArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");      //Сделал 'i + 1' чтобы отображение было ясным пользователю какой элемент по счету он вводит.
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write(array[i]);
        else    
        Console.Write(array[i] + ", ");
    }
}
Console.Write("Input namber elemets: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateUserArray(length);
ShowArray(myArray);
*/