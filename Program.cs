// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Console.WriteLine("Enter Number please");
// int number = Convert.ToInt32(Console.ReadLine());

// static void CheckIfDivide(int a, int b, int number)
// {
//     if (number % a == 0 && number % b == 0)
//     {
//         System.Console.WriteLine($"{number} делиться и на {a} и на {b}");
//     }
//     else
//     {
//         System.Console.WriteLine($"{number} не  делиться одновременно и на {a} и на {b}");
//     }
// }
// CheckIfDivide(7, 23, number);

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Enter coordinate x please");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter coordinate y please");
// int y = Convert.ToInt32(Console.ReadLine());

// static void WhichQuarterIsObject(int x, int y)
// {
//     string text = "the object is in";
//     if (x > 0 && y > 0)
//     {
//         System.Console.WriteLine($"{text} 1st quarter");
//     }
//     else if (x > 0 && y < 0)
//     {
//         System.Console.WriteLine($"{text} 2st quarter");
//     }
//     else if (x < 0 && y < 0)
//     {
//         System.Console.WriteLine($"{text} 3st quarter");
//     }
//     else
//     {
//         System.Console.WriteLine($"{text} 4st quarter");
//     }
// }

// WhichQuarterIsObject(x,y);

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Enter number between 10 and 99 please");
int number = Convert.ToInt32(Console.ReadLine());

static void BiggestDigit(int number)
{
    int firstDigit = number / 10;
    int lastDigit = number % 10;
    if (firstDigit > lastDigit)
    {
        System.Console.WriteLine(firstDigit);
    }
    else if (firstDigit == lastDigit)
    {
        System.Console.WriteLine("The digits are equal");
    }
    else
    {
        System.Console.WriteLine(lastDigit);
    }
}
if (number < 10 || number > 99)
{
    System.Console.WriteLine("Wrong number");
}
else
{
    BiggestDigit(number);
}