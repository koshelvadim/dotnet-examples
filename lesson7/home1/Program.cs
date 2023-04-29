void Main()
{
    bool isWork = true;
    while (isWork)
    {
        System.Console.Write("Enter command: ");
        string command = System.Console.ReadLine();
        switch (command)
        {
            case "task47":
                Task47();
                break;
            case "task50":
                Task50();
                break;
            case "task52":
                Task52();
                break;
            case "exit":
                isWork = false;
                break;
            default:
                System.Console.WriteLine("Warning! Enter only: task47 or task50 or task52 or exit");
                break;
        }
    }
}

int ReadInt(string message)
{
    System.Console.Write($"Enter {message}: ");
    int number;
    while (!int.TryParse(System.Console.ReadLine(), out number))
    {
        System.Console.Write($"Not a number. Enter {message}: ");
    }
    return number;
}

double[,] FillDoubleArray(int m, int n, int minValue, int maxValue)
{
    double[,] array = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.Next(minValue, 1 + maxValue) + rand.NextDouble(), 2);
        }
    }
    return array;
}

int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(minValue, 1 + maxValue);
        }
    }
    return array;
}

void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void CheckPositionElemetnDoubleArray(int[,] array, int posRow, int posCol)
{
    if (posRow < array.GetLength(0) && posCol < array.GetLength(1)) System.Console.WriteLine(array[posRow, posCol]);
    else System.Console.WriteLine("Element not find");
}

void GetArithmeticMeanColArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        System.Console.WriteLine($"arithmetic mean col {i} = {Math.Round(sum / (double)array.GetLength(0), 1)}");
    }
}

/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
void Task47()
{
    System.Console.WriteLine("Task47");
    int m = ReadInt("row m");
    int n = ReadInt("col n");
    int min = ReadInt("min element");
    int max = ReadInt("max element");

    PrintDoubleArray(FillDoubleArray(m, n, min, max));
}

/*
Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
void Task50()
{
    System.Console.WriteLine("Task50");
    int m = ReadInt("row m");
    int n = ReadInt("col n");
    int min = ReadInt("min element");
    int max = ReadInt("max element");
    int[,] Array = FillArray(m, n, min, max);

    PrintArray(Array);
    System.Console.WriteLine();
    int posRow = ReadInt("position array row");
    int posCol = ReadInt("position array col");
    CheckPositionElemetnDoubleArray(Array, posRow, posCol);
}

/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void Task52()
{
    System.Console.WriteLine("Task52");
    int m = ReadInt("row m");
    int n = ReadInt("col n");
    int min = ReadInt("min element");
    int max = ReadInt("max element");
    int[,] Array = FillArray(m, n, min, max);

    PrintArray(Array);
    System.Console.WriteLine();
    GetArithmeticMeanColArray(Array);
}

Main();