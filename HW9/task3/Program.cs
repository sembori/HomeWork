// Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using static System.Console;
Clear();
Write("Введите два натуральных числа M и N через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.Write($"Функция Аккермана = {FunctionAkkerman(int.Parse(parameters[0]), int.Parse(parameters[1]))} ");

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
}


