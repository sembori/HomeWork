//Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
using static System.Console;
Clear();
WriteLine("Посчитаем сумму всех цифр введенного числа!");
Write("Введите число : ");
int.TryParse(ReadLine(), out int number);
int[] numberElements = GetArray(LenghtOfArray(number), number);
Write($"Сумма всех цифр числа = {AddUp(numberElements)}");

int LenghtOfArray(int num)
{
    int size = 0;
    while (num > 0)
    {
        size++;
        num /= 10;

    }
    return size;
}

int[] GetArray(int lenght, int num1)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num1 % 10;
        num1 /= 10;
    }
    return array;
}

int AddUp(int[] array)
{

    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int elementOfNumber = array[i];
        result += elementOfNumber;
    }
    return result;
}