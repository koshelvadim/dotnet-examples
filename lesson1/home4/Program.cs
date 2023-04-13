/* принимаем на вход число N и выводим все четные числа от 1 до N */

System.Console.WriteLine("Введите число: ");
int number = int.Parse(System.Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        System.Console.Write(i + " ");
    }
}

