/* Задача 6: принимаем на вход число и выводим является ли оно четным */

System.Console.WriteLine("Введите число: ");
int number = int.Parse(System.Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine($"Число {number} является четным");
}
else
{
    System.Console.WriteLine($"Число {number} нечетное");
}
