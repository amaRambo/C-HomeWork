// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int FindMinSumRow(int[,] matr)
{
    int mini = 0;
    int minSum = 0;
    int i = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        minSum = minSum + matr[i, j];
    }

    for (i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 1; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            mini = i;
        }

    }
    return mini + 1;
}

int lenRows = Prompt("ВВедите кол-во строк: ");
int lenColumns = Prompt("ВВедите кол-во столбцов: ");
int[,] matr = CreateArray(lenRows, lenColumns);
PrintMatr(matr);
Console.WriteLine();
Console.WriteLine($"{FindMinSumRow(matr)} - строкa с наименьшей суммой элементов");
