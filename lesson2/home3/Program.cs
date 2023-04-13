/* принимаем на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. */

System.Console.Write("Введите число от 1 до 7: ");
int number = 0;

while (!int.TryParse(System.Console.ReadLine(), out number))
{
    System.Console.WriteLine("Это не число");
    System.Console.Write("Введите число: ");
}

if (number < 1 || number > 7)
{
    System.Console.Write("Введенное число не соответствует условию");
}
else if (number == 6 || number == 7)
{
    System.Console.Write("Да");
}
else
{
    System.Console.Write("Нет");
}
