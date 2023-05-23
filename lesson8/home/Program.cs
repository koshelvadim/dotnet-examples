void Main()
{
    bool isWork = true;
    while (isWork)
    {
        System.Console.Write("Enter command: ");
        string command = System.Console.ReadLine();
        switch (command)
        {
            case "task54":
                task54();
                break;
            case "task56":
                task56();
                break;
            case "task58":
                task58();
                break;
            case "task60":
                task60();
                break;
            case "task62":
                task62();
                break;
            case "exit":
                isWork = false;
                break;
            default:
                System.Console.WriteLine(
                "Warning! Enter only:\n" +
                "task54\n" +
                "task56\n" +
                "task58\n" +
                "task60\n" +
                "task62\n" +
                "exit");
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
        System.Console.WriteLine($"It's not a number.");
        System.Console.Write($"Enter {message}: ");
    }
    return number;
}

int[,] CreateMatrix(int firstLength, int secondLength, int minValue, int maxValue)
{
    int[,] matrix = new int[firstLength, secondLength];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string message = "new Matrix")
{
    System.Console.WriteLine($"Print {message}: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArray(int[] array, string message = "array")
{
    System.Console.WriteLine($"Print {message}: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[,] GetRangeMinToMaxElementMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}

int[] GetArraySumElements(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumElement = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElement += matrix[i, j];
        }
        array[i] = sumElement;
    }
    return array;
}

void GetMinElementArray(int[] array)
{
    int minEl = array[0];
    int pos = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (minEl > array[i])
        {
            minEl = array[i];
            pos = i;
        }
    }
    System.Console.WriteLine($"Min sum elements of row Matrix {minEl}, string - {pos}");
}

int[,] GetMultiMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Matrix can`t be multiplied ");
    int row = matrix1.GetLength(0);
    int col = matrix1.GetLength(1);
    int[,] matrixMulti = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < row; k++)
            {
                matrixMulti[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixMulti;
}

int RandomNumber()
{
    int num = new Random().Next(10, 100);
    return num;
}

int[,,] CreateMaitrix3D(int firstLegth, int secondLength, int thirdLength)
{
    int[,,] Matrix3D = new int[firstLegth, secondLength, thirdLength];
    for (int i = 0; i < Matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix3D.GetLength(1); k++)
            {
                int num = RandomNumber();
                if (Matrix3D[i, j, k] == num) k--;
                else Matrix3D[i, j, k] = num;
            }
        }
    }
    return Matrix3D;
}

void PrintMatrix3D(int[,,] Matrix3D)
{
    for (int i = 0; i < Matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix3D.GetLength(1); k++)
            {
                System.Console.Write($"{Matrix3D[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}



/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void task54()
{
    System.Console.WriteLine("start Task54");
    int firstLength = ReadInt("first length of Matrix");
    int secondLength = ReadInt("second length of Matrix");
    int minValue = ReadInt("min value of Matrix");
    int maxValue = ReadInt("man value of Matrix");
    int[,] newMatrix = CreateMatrix(firstLength, secondLength, minValue, maxValue);
    PrintMatrix(newMatrix);
    PrintMatrix(GetRangeMinToMaxElementMatrix(newMatrix), "Matrix range min to max element: ");
    System.Console.WriteLine("end Task54");
}
/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
void task56()
{
    System.Console.WriteLine("start Task56");
    int firstLength = ReadInt("first length of Matrix");
    int secondLength = ReadInt("second length of Matrix");
    int minValue = ReadInt("min value of Matrix");
    int maxValue = ReadInt("man value of Matrix");
    int[,] newMatrix = CreateMatrix(firstLength, secondLength, minValue, maxValue);
    PrintMatrix(newMatrix);
    int[] array = GetArraySumElements(newMatrix);
    PrintArray(array, "sum element row");
    GetMinElementArray(array);
    System.Console.WriteLine("end Task56");
}
/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
void task58()
{
    System.Console.WriteLine("start Task58");
    int firstLength = ReadInt("first length of Matrix");
    int secondLength = ReadInt("second length of Matrix");
    int minValue = ReadInt("min value of Matrix");
    int maxValue = ReadInt("man value of Matrix");
    int[,] newMatrix1 = CreateMatrix(firstLength, secondLength, minValue, maxValue);
    int[,] newMatrix2 = CreateMatrix(firstLength, secondLength, minValue, maxValue);
    PrintMatrix(newMatrix1, "first matrix");
    PrintMatrix(newMatrix2, "second matrix");
    PrintMatrix(GetMultiMatrix(newMatrix1, newMatrix2), "multi matrix");
}
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
void task60()
{
    System.Console.WriteLine("start Task60");
    int firstLength = ReadInt("first length of Matrix3D");
    int secondLength = ReadInt("second length of Matrix3D");
    int thirdLength = ReadInt("third length of Matrix3D");
    System.Console.WriteLine();
    int[,,] Matrix3D = CreateMaitrix3D(firstLength, secondLength, thirdLength);
    PrintMatrix3D(Matrix3D);
    System.Console.WriteLine("end Task60");
}
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void task62()
{

}

Main();
