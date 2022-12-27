using static System.Console;
Clear();

Write("Введите пятизначное число: ");
int a = Convert.ToInt32(ReadLine());

WriteLine((a/1000 + a%100)%11 == 0 ? "ДА" : "НЕТ");
