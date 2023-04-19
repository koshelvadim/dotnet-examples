/* Задание 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int number = ReadInt("number");
int[] array = GetArray(number);
System.Console.WriteLine(string.Join(" ", array));


int ReadInt(string argument)
{
    System.Console.Write($"Please, enter {argument}: ");
    int num;
    while (!int.TryParse(System.Console.ReadLine(), out num))
    {
        System.Console.WriteLine("It's not a number");
    }
    return num;
}

int[] GetArray(int number)
{
    int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

