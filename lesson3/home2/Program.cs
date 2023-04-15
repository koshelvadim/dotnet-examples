/* Принимает на вход координаты двух точек
 и находим расстояние между ними в 3d пространстве */

int x1 = ReadInt("x1");
int y1 = ReadInt("y1");
int z1 = ReadInt("z1");
int x2 = ReadInt("x2");
int y2 = ReadInt("y2");
int z2 = ReadInt("z2");

System.Console.WriteLine(GetDistance(x1, y1, z1, x2, y2, z2));

int ReadInt(string argument)
{
    System.Console.Write($"Введите координату {argument}: ");
    int i;

    while (!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число");
    }
    return i;
}

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(GetMathPow(x1, x2) + GetMathPow(y1, y2) + GetMathPow(z1, z2));
    return result;
}

double GetMathPow(int a, int b)
{
    double result = Math.Pow((a - b), 2);
    return result;
}