// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30



int Prompt(string msg)
{
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}


int FindSum(int m, int n)
{
    if (m >= n + 1)
    {
        return 0;
    }
    return m + FindSum(m + 1, n);
}

int m = Prompt("vvedite 4islo ");
int n = Prompt("vvedite 4islo ");
Console.WriteLine();
Console.WriteLine(FindSum(m, n));