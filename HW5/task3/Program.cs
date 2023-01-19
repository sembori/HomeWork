//  Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.
using static System.Console;
Clear();
Write("Введите через пробел длинну массива, его минимальное значение и максимальное значение: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] numbers = GetArray(int.Parse(parameters[0]), double.Parse(parameters[1]), double.Parse(parameters[2]));
Write("Ваш массив: ");
PrintArray(numbers);
double minimum = double.Parse(parameters[2]);
double maximum = 0;
foreach (var element in numbers)
{
    if (element < minimum)
    {
        minimum = element;
    }
    if (element > maximum)
    {
        maximum = element;
    }
}
Write($"Разница максимального и минимального элемента = {maximum-minimum}");

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

void PrintArray(double[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]} | ");
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}




