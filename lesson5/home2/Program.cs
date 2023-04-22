/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов с нечётными индексами.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int GetSumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

int length = ReadInt("количество элементов массива");
int minValue = ReadInt("минимальное значение элемента массива");
int maxValue = ReadInt("максимальное значение элемента массива");

int[] Array = GetIntArray(length, minValue, maxValue);
PrintArray(Array);
int result = GetSumOddElements(Array);
System.Console.WriteLine(result);
