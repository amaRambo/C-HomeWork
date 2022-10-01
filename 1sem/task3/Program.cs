// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("ВВедите число: ");
int value = Convert.ToInt32(Console.ReadLine());
if (value % 2 == 0)
{
    Console.WriteLine($"{value} является четным числом");
}
else
{
    Console.WriteLine($"{value} является нечетным числом");
}
