/* Домашка к первому уроку */

/* Задача 2: принимаем на вход два числа и выдаем какое меньше, а какое больше */
System.Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(System.Console.ReadLine());

if (numberA > numberB)
{
    System.Console.WriteLine($"Число {numberA} больше, чем число {numberB}");
}
else if (numberA < numberB)
{
    System.Console.WriteLine($"Число {numberA} меньше, чем число {numberB}");
}
else
{
    System.Console.WriteLine($"Числа {numberA} и {numberB} равны");
}
