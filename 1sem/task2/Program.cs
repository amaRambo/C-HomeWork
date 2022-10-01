// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите значение первого числа: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение второго числа: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение третьего числа: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if ( b > max)
{
    max =b;
}
if ( c > max)
{
    max = c;
}
Console.WriteLine($" Наибольшее значение = {max}");