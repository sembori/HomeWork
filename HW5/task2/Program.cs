// Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
using static System.Console;
Clear();
int[] array = GetArray(20);
Write($"Масссив: ");
PrintArray(array);
WriteLine($"Сумма чисел на нечетных позициях = {ElementSum(array)}");

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
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
    WriteLine($"{inArray[inArray.Length - 1]}]");
}

int ElementSum(int[] array)
{
    int sumOfElements = 0;
    for (int i = 0; i < array.Length; i = i + 2) 
    {
        sumOfElements += array[i];
    }
    return sumOfElements;
}