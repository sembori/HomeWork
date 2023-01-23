// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
using static System.Console;
Clear();
Write("Введите через пробел ваши числа: ");
string[] enterNumbers = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Write("Ваши числа: ");
PrintArray(StringToInt(enterNumbers));
WriteLine($"Из них {PositiveNumbers(StringToInt(enterNumbers))} положительных!");

int[] StringToInt(string[] inArray)
{
    int[] array = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        array[i] = int.Parse(inArray[i]);
    }
    return array;
}

int PositiveNumbers(int[] inArray)
{
    int positive = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > 0)
        {
            positive++;
        }
    }
    return positive;
}


void PrintArray(int[] inArray)
{
    Write("[ ");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]} | ");
    }
    WriteLine($"{inArray[inArray.Length - 1]} ]");
}