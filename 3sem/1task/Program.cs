// Задача 1: Напишите программу, которая принимает на вход пятизначное число
//           и проверяет, является ли оно палиндромом.

int enter(string msg)
{
    Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = enter("Введите число: ");

double reverse(int NN)
{
    int number = N;
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    double rev = 0;
    int ii = 0;
    int temp1 = N; int temp2 = 0;
    while (i >= ii)
    {
        temp2 = temp1 % 10;
        temp1 = temp1 / 10;
        rev = rev + temp2 * Math.Pow(10, i - ii - 1);
        ii = ii + 1;
    }
    return rev;
}
if (N == reverse(N))
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}
