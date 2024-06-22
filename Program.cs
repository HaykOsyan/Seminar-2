// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Enter Number please");
int number = Convert.ToInt32(Console.ReadLine());

static void CheckIfDivide(int a, int b, int number)
{
    if (number % a == 0 && number % b == 0)
    {
        System.Console.WriteLine($"{number} делиться и на {a} и на {b}");
    }
    else
    {
        System.Console.WriteLine($"{number} не  делиться одновременно и на {a} и на {b}");
    }
}
CheckIfDivide(7, 23, number);
