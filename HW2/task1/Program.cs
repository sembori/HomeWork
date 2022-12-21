using static System.Console;
Clear();

Write("Введите трехзначное число: ");
int a = Convert.ToInt32(ReadLine());
WriteLine(a < 100 || a > 999? "Число должно быть трехзначным" : $"Второе число:  {a/10%10} ");

