// семинар 4 генерация и отображение массива случайных чисел
/*
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
*/


// семинар 1


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

/*
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
*/


// принимает на вход координаты точки ненулевые и выдает номер четверти плоскости точки

/*
int FindQuandrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("input the first coordinate: x = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input the first coordinate: y = ");
double yA = Convert.ToDouble(Console.ReadLine());

int result = FindQuandrant(xA, yA);
Console.WriteLine(result);
*/


// по заданному номеру четверти показывает диапазон возможных координат в этой четверти
/*
void Quadrant(int q)
{
    if(q == 1) Console.Write("Координаты x и y больше нуля");
    if(q == 2) Console.Write("Координаты x меньше нуля, y больше нуля");
    if(q == 3) Console.Write("Координаты x и y меньше нуля");
    if(q == 4) Console.Write("Координаты x больше нуля и y меньше нуля");
}

Console.Write("Введите номер квадранта: ");
int n = Convert.ToInt32(Console.ReadLine());

Quadrant(n);
*/

// принимает на вход координаты 2 точек и находит расстояние между ними
/*
double Gipotenuza(double xA, double yA, double xB, double yB)
{
    double a = xB - xA;
    double b = yB - yA;
    //double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
    double c = Math.Round(Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)), 3);
        
    return c;
}

double result = Gipotenuza(2.3, 3.4, 6.6, 7.5);

Console.Write("гипотенуза равна: " + result);
*/

// принимает на вход число n и выдает ряд квадратов чисел от 1 до n
/*
void FindQuad(int n)
{
    int result = 1;
    
    while(result <= n)
    {
        Console.Write(Math.Pow(result, 2) + ", ");
        result++;
    }

}

Console.WriteLine("введите число n");
int x = Convert.ToInt32(Console.ReadLine());

FindQuad(x);
*/         
