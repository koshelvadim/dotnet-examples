/* Задание 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int number1 = ReadInt("number1");
int number2 = ReadInt("number2");

int resultPow = GetPow(number1, number2);
System.Console.WriteLine(resultPow);

int GetPow(int a, int b)
{
    int length = b;
    int result = 1;
    for (int i = 1; i <= length; i++)
    {
        result = result * a;
    }
    return result;
}

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

