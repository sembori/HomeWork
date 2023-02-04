//  Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using static System.Console;
Clear();
Write("Введите два натуральных числа M и N через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
NumberSum(int.Parse(parameters[0]), int.Parse(parameters[1]), 0);


void NumberSum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Write($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + numberM++;
    NumberSum(numberM, numberN, sum);
}