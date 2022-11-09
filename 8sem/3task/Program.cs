// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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
            Console.Write($"{matr[i, j]}\t");
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

int[,] ProductMatr(int[,] matr1, int[,] matr2)
{
    int row = matr1.GetLength(0);
    int col = matr2.GetLength(1);

    int[,] product = new int[row, col];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                product[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return product;
}


int lenRows1 = Prompt("ВВедите кол-во строк: ");
int lenColumns1 = Prompt("ВВедите кол-во столбцов: ");
int[,] matr1 = CreateArray(lenRows1, lenColumns1);
int lenRows2 = Prompt("ВВедите кол-во строк: ");
int lenColumns2 = Prompt("ВВедите кол-во столбцов: ");
int[,] matr2 = CreateArray(lenRows2, lenColumns2);
PrintMatr(matr1);
Console.WriteLine();
PrintMatr(matr2);
Console.WriteLine();
PrintMatr(ProductMatr(matr1, matr2));
