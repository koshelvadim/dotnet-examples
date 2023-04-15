/* принимаем на вход число N и выводим таблицу кубов чисел от 1 до N */

int number = ReadInt("N");
GetPow(number);

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

void GetPow(int number)
{
    for (int i = 1; i <= number; i++)
    {
        System.Console.Write($"{Math.Pow(i, 3)} ");
    }
}