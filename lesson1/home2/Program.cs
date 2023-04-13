/* Задача 4: принимаем на вход три числа и выводим максимальное */

System.Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(System.Console.ReadLine());

int numberMax = numberA;

if (numberB > numberMax)
{
    numberMax = numberB;
    if (numberC > numberMax)
    {
        numberMax = numberC;
    }
}
else if (numberC > numberMax)
{
    numberMax = numberC;
}
System.Console.WriteLine($"Максимальное число {numberMax}");

