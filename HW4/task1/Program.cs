//Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
using static System.Console;
Clear();
WriteLine("Возведем число A в степень B.");
Write("Введите число A: ");
int.TryParse(ReadLine(), out int A);
Write("Введите число B: ");
int.TryParse(ReadLine(), out int B);

if (B > 0)
{
    WriteLine($"{A} в степени {B} = {AInGradeB(A, B)}");
}
else
{
    WriteLine("Степень должна быть больше 0");
}

int AInGradeB(int a, int b)
{
    int result = a;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
        i++;
    }
    return result;
}

