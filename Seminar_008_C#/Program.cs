//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min passible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max passible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minvalue, maxvalue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ReversArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
        for(int i = 0; i < array.GetLength(0) - 1; i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
    else
    {
        Console.WriteLine("Reverse is impossible!");
    }
}


int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

ReversArray(myArray);
Show2dArray(myArray);
*/


//Задайте двумерный массив. Напишите программу, которая поменяет местами строки, номера которых заданы пользователем.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min passible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max passible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minvalue, maxvalue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ReversRows(int[,] array, int x, int y)
{
    if(x != y && x <= array.GetLength(0) && y <= array.GetLength(0))
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[x,j];
            array[x,j] = array[y,j];
            array[y,j] = temp;
        }
    }
    else Console.WriteLine("Reverse is impossible!");
    
}

int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine("Введите номер первой строки: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер второй строки: ");
int second = Convert.ToInt32(Console.ReadLine());

ReversRows(myArray, first, second);
Show2dArray(myArray);
*/


//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.


int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min passible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max passible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minvalue, maxvalue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FindMinElement(int[,] array)
{   
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)        
        {   if(array[i,j] < array[iMin,jMin])
            {
                iMin = i;
                jMin = j;
            }
            
        }

    int[,] newArray = new int[array.GetLength(0) - 1,array.GetLength(1) - 1];
    for (int i = 0, x = 0; i < array.GetLength(0); i++, x++)
    {
        if(i == iMin)
        {
            x = x - 1;
        }
        else
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)        
            {
                if(j == jMin)
                {
                    y = y - 1;
                }
                else
                {
                    newArray[x,y] = array[i,j];
                }
            }
        }
    }
    return newArray;        
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int[,] newMyArray = FindMinElement(myArray);
Show2dArray(newMyArray);