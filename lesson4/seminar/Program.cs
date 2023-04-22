// int[] array = { 6, 8, 3, 2, 1, 4, 5, 7 };

// PrintArray(array);
// SortArray(array);
// PrintArray(array);

// void PrintArray(int[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// void SortArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }

//         int temp = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temp;
//     }
// }



// int number1 = ReadInt("число");
// int number2 = ReadInt("число");

// System.Console.WriteLine(number1);
// System.Console.WriteLine(number2);
// GetPow(number1, number2);

// int ReadInt(string argument)
// {
//     System.Console.Write($"Введите число {argument}: ");
//     int i;

//     while (!int.TryParse(System.Console.ReadLine(), out i))
//     {
//         System.Console.WriteLine("Это не число");
//     }
//     return i;
// }

// void GetPow(int a, int b)
// {
//     int res = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         res = res * a;
//     }
//     System.Console.WriteLine(res);
// }


// int number = ReadInt("число");
// int length = number.ToString().Length;

// System.Console.WriteLine(length);
// int res = GetSumElement(number, length);
// System.Console.WriteLine(res);

// int ReadInt(string argument)
// {
//     System.Console.Write($"Введите число {argument}: ");
//     int i;

//     while (!int.TryParse(System.Console.ReadLine(), out i))
//     {
//         System.Console.WriteLine("Это не число");
//     }
//     return i;
// }

// int GetSumElement(int number, int length)
// {
//     int sum = 0;
//     for (int i = 1; i <= length; i++)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }
//     return sum;
// }
Console.WriteLine(5 / 10);
int number = ReadInt("число");
int[] array = GetArray(number);
System.Console.WriteLine(string.Join(" ", array));

int ReadInt(string argument)
{
    System.Console.Write($"Введите число {argument}: ");
    int i;

    while (!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число");
    }
    return i;
}

int[] GetArray(int number)
{
    int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

