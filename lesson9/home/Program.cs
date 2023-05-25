void Main()
{
    bool isWork = true;
    while (isWork)
    {
        System.Console.Write("Enter command: ");
        string command = System.Console.ReadLine();
        switch (command)
        {
            case "task64":
                task64();
                break;
            case "task66":
                task66();
                break;
            case "task68":
                task68();
                break;
            case "exit":
                isWork = false;
                break;
            default:
                System.Console.WriteLine(
                "Warning! Enter only:\n" +
                "task64\n" +
                "task66\n" +
                "task68\n" +
                "exit");
                break;
        }
    }
}
/*ОБЩИЕ МЕТОДЫ*/
int ReadInt(string message)
{
    System.Console.Write($"Enter {message}: ");
    int number;
    while (!int.TryParse(System.Console.ReadLine(), out number))
    {
        System.Console.WriteLine($"It's not a number.");
        System.Console.Write($"Enter {message}: ");
    }
    return number;
}

void GetRangeNumber(int m, int n)
{
    if (m < n)
    {
        GetRangeNumber(m, n - 1);
        System.Console.Write($"{n}, ");
    }
    else System.Console.Write($"{m}, "); ;
}

int GetSumNumber(int m, int n)
{
    if (m < n) return GetSumNumber(m, n - 1) + n;
    else return m;
}

void CheckNegativeNumber(int a, int b)
{
    if (a < 0 || b < 0)
    {
        System.Console.WriteLine("The number cannot be negative");
        task68();
    }
}

int FunctionAkkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return FunctionAkkerman(n - 1, 1);
    else
        return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
}

/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/
void task64()
{
    System.Console.WriteLine("start task64");
    int m = ReadInt("number m");
    int n = ReadInt("number n");
    GetRangeNumber(m, n);
    System.Console.WriteLine();
    System.Console.WriteLine("end task64");
}
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
void task66()
{
    System.Console.WriteLine("start task66");
    int m = ReadInt("number m");
    int n = ReadInt("number n");
    System.Console.WriteLine($"Result sum element: {GetSumNumber(m, n)} ");
    System.Console.WriteLine("end task66");
}
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
void task68()
{
    System.Console.WriteLine("start task68");
    int m = ReadInt("number m");
    int n = ReadInt("number n");
    CheckNegativeNumber(m, n);
    System.Console.WriteLine($"Result Akkerman: {FunctionAkkerman(m, n)} ");
    System.Console.WriteLine("end task68");
}

Main();