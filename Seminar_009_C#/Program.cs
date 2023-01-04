// 1 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if(num > 1) 
    {
        ShowNums(num - 1);
    }

    Console.Write(num + " ");
}

Console.Write("input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);
*/

//2  Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
int  GetSum(int num)
{
    if(num != 0)
    {
        return GetSum(num / 10) + num % 10;
    }
    return 0;
}

Console.Write(GetSum(1234));
*/

//Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N.

/*
void ShowNums(int a, int b)
{
    if(b > a) 
    {
        if(a != b) 
        ShowNums(a, b - 1);
        
        Console.Write(b + " ");
    }
    else
    {
        if(a != b) 
        ShowNums(a, b + 1);
        Console.Write(b + " ");
    }
    
}

Console.Write("input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(m,n);

*/



//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B.

double FindPow(int a, int b)
{
    if(b > 0)
    {
        return FindPow(a, b - 1) * a;
    }
    if(b < 0)
    {
        return FindPow(a, b + 1) / a;
    }

return 1;
}

Console.Write("input a number A: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number B: ");
int n = Convert.ToInt32(Console.ReadLine());

double res = FindPow(m,n);

Console.WriteLine(res);
