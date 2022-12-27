using static System.Console;
Clear();

Write("Введите пятизначное число: ");
int a = Convert.ToInt32(ReadLine());

if (a > 99999)
{
    WriteLine("Введите меньшее число");
}
else if (a < 10000){
    WriteLine("Введите большее число");
}else
{
    WriteLine((a / 1000 + a % 100) % 11 == 0 ? "ДА" : "НЕТ");
}