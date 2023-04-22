/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементами массива.
[3,21 7,04 22,93 -2,71 78,24] -> 80,95
*/

int ReadInt(string argument)
{
    System.Console.Write($"Введите {argument} ");
    int i;

    while (!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число");
    }
    return i;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

double[] GetDoubleArray(int length, int minValue, int maxValue)
{
    maxValue++;
    double[] array = new double[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble(), 2);
    }
    return array;
}

double FindeMaxElement(double[] array)
{
    double MaxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > MaxElement) MaxElement = array[i];
    }
    return MaxElement;
}

double FindeMinElement(double[] array)
{
    double MinElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < MinElement) MinElement = array[i];
    }
    return MinElement;
}


int length = ReadInt("количество элементов массива");
int minValue = ReadInt("минимальное значение элемента массива");
int maxValue = ReadInt("максимальное значение элемента массива");

double[] DoubleArray = GetDoubleArray(length, minValue, maxValue);
PrintArray(DoubleArray);
double max = FindeMaxElement(DoubleArray);
System.Console.WriteLine($"максимальный элемент массива {max}");
double min = FindeMinElement(DoubleArray);
System.Console.WriteLine($"минимальный элемент массива {min}");
System.Console.WriteLine($"Разница максимального и минимального элементов {max - min}");



