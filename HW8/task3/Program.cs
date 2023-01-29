//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static System.Console;
Clear();
Write("Введите размер матрицы через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), 0, 100);
int[,] secondArray = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), 0, 100);
int[,] resultArray = new int[int.Parse(parameters[0]), int.Parse(parameters[1])];

PrintMatrixArray(array);
WriteLine();
PrintMatrixArray(secondArray);
WriteLine();
MultiplyMatrix(array, secondArray);

void MultiplyMatrix(int[,] inArray, int[,] inArray2)
{
    if (array.GetLength(0) != secondArray.GetLength(1))
    {
        WriteLine(" Нельзя перемножить ");
        return;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultArray[i, j] += array[i, k] * secondArray[k, j];
            }
        }
    }
   PrintMatrixArray(resultArray);
}



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
            Write($"{inArray[i, j],7} ");
        }
        WriteLine();
    }
}