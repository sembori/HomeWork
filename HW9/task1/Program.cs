// Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using static System.Console;
Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine());
PrintNumbers(num);

void PrintNumbers(int number)
{
    if (number == 1)
    {
        Write($"{1}. ");;
    }
    else
    {
        Write($"{number}, ");
        PrintNumbers(number - 1);
    }
}