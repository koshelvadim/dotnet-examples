/* принимаем пятизначное число и проверяем, является ли оно палиндромом */
int number = ReadInt("число");
string num = number.ToString();
System.Console.WriteLine(GetPalindrom(num));


int ReadInt(string argument)
{
    System.Console.Write($"Введите пятизначное {argument}: ");
    int i;

    while (!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число");
    }
    if (i > 99999 || i < 10000)
    {
        System.Console.WriteLine("Это не пятизначное число");
    }
    return i;
}

string GetPalindrom(string num)
{
    if (num[0] == num[4] && num[1] == num[3])
        return "Да";
    else
        return "Нет";
}
