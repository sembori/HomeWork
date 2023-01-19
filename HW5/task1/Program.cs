// Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
using static System.Console;
Clear();
Write("Сейчас мы создадим массив. Для этого введите количество его элементов: ");
int massive_lenght = int.Parse(ReadLine()!);
int[] numbers = GetArray(massive_lenght);
WriteLine("Отлично! Ваш массив: ");
PrintArray(numbers);
int evenNumbers = 0;
foreach (var element in numbers)
{
    if (element % 2 == 0)
    {
        evenNumbers++;
    }
    else
    {
        evenNumbers = evenNumbers + 0;
    }
}
WriteLine($" В этом массие {evenNumbers} четных чисел!");

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}


