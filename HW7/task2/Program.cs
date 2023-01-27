// Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9
using static System.Console;
Clear();
WriteLine("Введите позиции элемента в двумерном массиве через запятую: ");
string[] parameters = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);
PrintMatrixArray(GetMatrixArray(4, 8, 0, 10));
WriteLine();
SearchElement(GetMatrixArray(4, 8, 0, 10), int.Parse(parameters[0]), int.Parse(parameters[1]));

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}

void SearchElement(int[,] array, int rws, int clms)
{
    if (rws < 4 && clms < 8)
    {
        Write($"Значение элемента = {array[rws, clms]}");
    }
    else if (rws < 0 && rws >= 4 && clms < 0 && clms >= 8)
    {
        WriteLine("Такого элемента нет!");
    }
}