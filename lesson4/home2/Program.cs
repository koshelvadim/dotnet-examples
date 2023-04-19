/* Задание 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int number = ReadInt("number");
int sumElement = GetSumElement(number);
System.Console.WriteLine(sumElement);

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

int GetSumElement(int number)
{
    int sum = 0;
    int length = number.ToString().Length;

    for (int i = 0; i < length; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}