


int enter(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] MatrixMaker(int str, int stlb)
{
    int[,] matr = new int[str, stlb];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrex(int[,] matr)
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

int SumMax(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int max = matr[i, 0];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (max < matr[i, j])
            {
                max = matr[i, j];
            }
        }
        sum = sum + max;
    }
    return sum;
}

int str = enter("Введите кол-во строк: ");
int stlb = enter("Введите кол-во столбцов: ");
int[,] matr = MatrixMaker(str, stlb);
PrintMatrex(matr);
Console.WriteLine(SumMax(matr));
