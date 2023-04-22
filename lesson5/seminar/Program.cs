/* Семинар 5 
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
*/



int ReadInt(string argument)
{
    System.Console.Write($"Введите {argument}: ");
    int i;

    while (!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число");
    }
    return i;
}

int[] GetArray(int size, int minValue = -10, int maxValue = 99)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}

int size = 12;
int[] numbers = GetArray(size);
PrintArray(numbers);
int sum = GetSum(numbers);
System.Console.WriteLine(sum);

/*Задача 32: Напишите программу замены элементов массива: положительные
 элементы замените на соответствующие отрицательные, и наоборот.*/



int[] GetPluse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}




int[] num = GetPluse(numbers);
PrintArray(num);

/*Задача 33: Задайте массив. Напишите программу,
которая определяет, присутствует ли заданное число в массиве.*/

bool GetFind(int[] array, int number)
{

    bool flag = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number || flag == true) flag = false;
    }
    return flag;
}
int number = ReadInt("number");
bool fl = GetFind(num, number);
if (fl) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");


/*Задача 35: Задайте одномерный массив из 10 случайных чисел. 
Найдите количество элементов массива,
значения которых лежат в отрезке [10,99].
*/

int CountElementsInSegment(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}