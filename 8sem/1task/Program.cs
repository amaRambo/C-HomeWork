// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

int[,] StreamlineMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(1) - 1; j++)
            {
                if (matr[i, j] < matr[i, j + 1])
                {
                    int tmp = matr[i, j + 1];
                    matr[i, j + 1] = matr[i, j];
                    matr[i, j] = tmp;
                }
            }
        }
    }
    return matr;
}

int lenRows = Prompt("ВВедите кол-во строк: ");
int lenColumns = Prompt("ВВедите кол-во столбцов: ");
int[,] matr = CreateArray(lenRows, lenColumns);
PrintMatr(matr);
Console.WriteLine();
int[,] matr1 = StreamlineMatr(matr);
PrintMatr(matr1);