// Задача 2: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

int enter(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int FindElem(int[,] array, int M, int N)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == M && j == N)
            {
                return array[i, j];
            }
        }
    }
    return -1;
}

int m = 4;
int n = 5;

int[,] array = CreateArray(m, n);
PrintArray(array);

Console.WriteLine();

int M = enter("Введите номер строки: ") - 1;
int N = enter("Введите номер столбца: ") - 1;

if (M >= 0 && M <= m && N >= 0 && N <= n)
{
    int result = FindElem(array, M, N);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("нет такого элемента в матрице");
}