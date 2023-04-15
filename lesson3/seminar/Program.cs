/* Первая задача */
// int x = ReadInt("x");
// int y = ReadInt("y");

// if (IsCoordinatesCorrect(x, y))
//     System.Console.WriteLine(GetQuarter(x, y));
// else
//     System.Console.WriteLine("Ooops");

// int ReadInt(string argument)
// {
//     System.Console.WriteLine($"Input {argument}: ");

//     int i;

//     while (!int.TryParse(System.Console.ReadLine(), out i))
//     {
//         System.Console.WriteLine("It's not a number");
//     }
//     return i;
// }

// int GetQuarter(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }
//     else if (x < 0 && y > 0)
//     {
//         return 2;
//     }
//     else if (x < 0 && y < 0)
//     {
//         return 3;
//     }
//     else
//     {
//         return 4;
//     }
// }

// bool IsCoordinatesCorrect(int x, int y)
// {
//     if (x == 0 && y == 0)
//     {
//         return false;
//     }
//     return true;
// }



/* Вторая задача
Принимает номер четверти и выводит предел x и y */

// int number = ReadInt("четверти");
// System.Console.WriteLine(GetLimit(number));

// int ReadInt(string argument)
// {
//     System.Console.WriteLine($"Введите номер {argument}: ");

//     int i;

//     while (!int.TryParse(System.Console.ReadLine(), out i))
//     {
//         System.Console.WriteLine("Это не число");
//     }
//     return i;
// }

// string GetLimit(int number)
// {
//     if (number == 1)
//     {
//         return "x=(0 до +бесконечность), y=(0 до +бесконечность)";
//     }
//     else if (number == 2)
//     {
//         return "x=(-бесконечность до 0), y=(0 од +бесконечность)";
//     }
//     else if (number == 3)
//     {
//         return "x=(-бесконечность до 0), y=(-бесконечность до 0)";
//     }
//     else
//     {
//         return "x=(0 до +бесконечность), y=(-бесконечность до 0)";
//     }
// }


/* Третья задача
Принимает координаты двух точек и находит расстояние между ними 
A(3,6);B(2,1) - 5,09
A(7,-5);B(1,-1) - 7,21

(x1-x2)^2 +(y1-y2)^2*/

// int x1 = ReadInt("x1");
// int y1 = ReadInt("y1");
// int x2 = ReadInt("x2");
// int y2 = ReadInt("y2");

// System.Console.WriteLine(GetDistance(x1, y1, x2, y2));

// int ReadInt(string argument)
// {
//     System.Console.Write($"Введите координату {argument}: ");
//     int i;

//     while (!int.TryParse(System.Console.ReadLine(), out i))
//     {
//         System.Console.WriteLine("Это не число");
//     }
//     return i;
// }

// double GetDistance(int x1, int y1, int x2, int y2)
// {
//     double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
//     return result;
// }



/* Четвертая задача
Принимает на вход число N и выдаем квадраты чисел от 1 до N

2 - 1,4
*/
int number = ReadInt("N");
GetSqrt(number);

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

void GetSqrt(int number)
{
    for (int i = 1; i <= number; i++)
    {
        System.Console.Write($"{Math.Pow(i, 2)} ");
    }
}
