//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
    {
        for (int i = 0; i < length; i++)
        {
            
        }
    }    
}








int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);