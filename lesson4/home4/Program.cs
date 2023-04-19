/*
Пользователь вводит стороны прямоугольника и квадрата, проверить можно ли вписать квадрат в прямоугольник
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

void GetCheck(int a, int b, int c)
{
    if (c <= a && c <= b) System.Console.WriteLine($"Квадрат со стороной {c} можно вписать в прямоугольник со сторонами {a} и {b}");
    else System.Console.WriteLine($"Квадрат со стороной {c} нельзя вписать в прямоугольник со сторонами {a} и {b}");
}

int lengthA = ReadInt("длина прямоугольника");
int lengthB = ReadInt("ширина прямоугольника");
int lengthC = ReadInt("сторона квадрата");

GetCheck(lengthA, lengthB, lengthC);

