// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 



int Prompt(string msg)
{
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}


int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }

    if (m > 0 && n > 0)
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
    return 0;
}

int m = Prompt("vvedite 4islo ");
int n = Prompt("vvedite 4islo ");
Console.WriteLine();
Console.WriteLine(FunctionAkkerman(m, n));