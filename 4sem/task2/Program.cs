// Задача 2: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе. Функция должна на вход 
// принимать число, а выдавать сумму его цифр


int enter(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int sum(int N)
{
    int number = 0;
    while (N > 0)
    {
        number = number + N % 10;
        N = N / 10;
    }
    return number;
}

Console.WriteLine(sum(enter("Введите число: ")));
