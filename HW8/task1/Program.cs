// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using static System.Console;
Clear();

Write("Введите размер матрицы, минимальное и максимальное значение через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
WriteLine("Первоначальный массив: ");
PrintMatrixArray(array);
LargerToSmaller(array);


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

void LargerToSmaller(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < inArray.GetLength(1) - 1; k++)
        {
            if (inArray[i, k] < inArray[i, k + 1]) 
            {
                int temp = 0;
                temp = inArray[i, k];
                inArray[i, k] = inArray[i, k + 1];
                inArray[i, k + 1] = temp;
            }
        }
    }
}
WriteLine("Измененный массив: ");
PrintMatrixArray(inArray);
}