int[] array = new int[10];
int[] array2 = new int[10];

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

FillArray(array);
System.Console.WriteLine("Исходный массив: ");
System.Console.WriteLine($"[{string.Join(',', array)}]");

array2 = array;


// Сортировка пузырьком(Bubble Sort)
// Время: O(n ^ 2)
// Память: O(n)
void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                int t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
}

System.Console.WriteLine("Сортировка пузырьком: ");
BubbleSort(array2);
System.Console.WriteLine($"[{string.Join(',', array2)}]");

// Коктейльная сортировка(Cocktail sort)