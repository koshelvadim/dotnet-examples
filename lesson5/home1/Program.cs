/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] GetIntArray(int length, int minValue, int maxValue)
{
    maxValue++;
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minValue, maxValue);
    }
    return array;
}

int GetQuantityEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int length = ReadInt("количество элементов массива");
int minValue = ReadInt("минимальное трехзначное значение элемента массива");
int maxValue = ReadInt("максимальное трехзначное значение элемента массива");

int[] Array = GetIntArray(length, minValue, maxValue);
PrintArray(Array);
int result = GetQuantityEven(Array);
System.Console.WriteLine(result);







