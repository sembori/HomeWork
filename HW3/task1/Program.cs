using static System.Console;
Clear();

Write("Введите пятизначное число: ");
int a = Convert.ToInt32(ReadLine());

if (a > 99999 || a < 10000)
{
    WriteLine("Число должно быть пятизначным!");
}
else
{
    WriteLine((a / 1000 + a % 100) % 11 == 0 ? "ДА" : "НЕТ");
}