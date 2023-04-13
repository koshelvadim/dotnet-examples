/* Принимаем на вход число и сообщаем, какая третья цифра. Если ее нет - выод нет */
System.Console.Write("Введите число: ");
int number = 0;

while (!int.TryParse(System.Console.ReadLine(), out number))
{
    System.Console.WriteLine("Это не число");
    System.Console.Write("Введите число: ");
}


if (number < 100 && number > 0)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (number < 1000)
{
    System.Console.Write(number % 10);
}
else if (number < 10000)
{
    System.Console.Write((number / 10) % 10);
}
else if (number < 100000)
{
    System.Console.Write((number / 100) % 10);
}
else
{
    System.Console.Write("Число слишком большое");
}