using static System.Console;
Clear();

Write("Введите любое число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine (number < 100? "Третьей цифры нет(" : $"Третья цифра: {number/100%10}");
