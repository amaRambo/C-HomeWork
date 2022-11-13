// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}


void PrintNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        Console.Write(m + " ");
    }
    PrintNumbers(m + 1, n);
}

int m = Prompt("vvedite 4islo ");
int n = Prompt("vvedite 4islo ");
Console.WriteLine();
PrintNumbers(m, n);