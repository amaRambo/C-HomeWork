// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B (и в нулевую степень).
// Использовать свои функции,не использовать Math.Pow

int enter(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int a = enter("Введите первое число: ");
int b = enter("Введите второе число: ");

int Multy(int a, int b)
{
    if(b !=0)
    {
        int number = 1;
    int i = 1;
    while(i<=b)
    {
        number = number * a;
        i++;
    }
    return number;
    }
    else
    {
        return 1;
    }
    
}
Console.WriteLine(Multy(a,b));