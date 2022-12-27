using static System.Console;
Clear();
int i = 1;
Write("Сейчас мы выведем все кубы чисел от 1 до: ");
int.TryParse(ReadLine(), out int n);

if (n <= 1)
{
    WriteLine("Число должно быть больше 1!");

}
else
{
    while (i <= n)
    {
        WriteLine($"Куб числа {i} - {Math.Pow(i, 3)} ");
        i++;
    }
}