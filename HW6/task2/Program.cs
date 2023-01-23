// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
using static System.Console;
Clear();
WriteLine("Сейчас мы найдем точку пересечения двух прямых, для этого введите переменные.");
Write("Перепенная а1 = ");
int.TryParse(ReadLine(), out int a1);
Write("Перепенная b1 = ");
int.TryParse(ReadLine(), out int b1);
Write("Перепенная а2 = ");
int.TryParse(ReadLine(), out int a2);
Write("Перепенная b2 = ");
int.TryParse(ReadLine(), out int b2);
Write("Координаты точки пересечения: ");
Point(a1, b1, a2, b2);

void Point(int A1, int B1, int A2, int B2)
{
    int x = (A2 - A1) / (B1 - B2);
    int y = B1 * x + A1;
    Write($"{x},{y}.");
}

