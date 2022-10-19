// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int enter(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");

int k1 = enter("Введите k1: ");
int k2 = enter("Введите k2: ");
int b1 = enter("Введите b1: ");
int b2 = enter("Введите b2: ");

double x = 0;
double y = 0;

if (k1 != k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}

Console.WriteLine($"({x},{y}) - точка пересечения");