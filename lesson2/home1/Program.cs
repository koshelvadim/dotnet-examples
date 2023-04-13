/* Принимаем на вход 3х-значное число и на выходе показываем вторую цифру этого числа*/

System.Console.Write("Введите трехзначное число: ");
int number = 0;

while (!int.TryParse(System.Console.ReadLine(), out number))
{
    System.Console.WriteLine("Это не число");
    System.Console.Write("Введите трехзначное число: ");
}
if (number > 99 && number < 1000)
{
    int num = (number / 10) % 10;
    System.Console.WriteLine(num);
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число!");
}
