/*
Задача 43: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

x = (b2 - b1) / (k1 - k2)
y = (k1*(b2-b1)/(k1-k2)+b1)
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

void PointIntersection(double b1, double k1, double b2, double k2)
{
    if (b1 == b2 && k1 == k2) System.Console.WriteLine($"Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * (b2 - b1) / (k1 - k2) + b1);
        System.Console.WriteLine($"Точка пересечения - ({x}; {y})");
    }
}

double b1 = ReadInt("b1");
double k1 = ReadInt("k1");
double b2 = ReadInt("b2");
double k2 = ReadInt("k2");

PointIntersection(b1, k1, b2, k2);