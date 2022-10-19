// Задача 5: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)


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

int SumMin(int[,] matr)
{
    int sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int min = matr[0, j];
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            if (min > matr[i, j])
            {
                min = matr[i, j];
            }
        }
        sum = sum + min;
    }
    return sum;
}

int str = enter("Введите кол-во строк: ");
int stlb = enter("Введите кол-во столбцов: ");
int[,] matr = MatrixMaker(str, stlb);
PrintMatrex(matr);
int sum_max = SumMax(matr);
int sum_min = SumMin(matr);
Console.WriteLine($"{sum_max} - {sum_min} = {sum_max - sum_min}");