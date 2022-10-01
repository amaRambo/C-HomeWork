// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите значение первого числа: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение второго числа: ");
int b = Convert.ToInt32(Console.ReadLine());
if( a > b)
{
    Console.WriteLine($"Максимальное значение = {a} ");
}
else
{
    if( a==b)
    {
     Console.WriteLine("Числа равны");   
    }
    else
    {
     Console.WriteLine($"Максимальное значение = {b} ");   
    }
    
}
