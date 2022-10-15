// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = CreateArray(9, 0, 200);
PrintArray(array);
Console.WriteLine();

int Max(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

int max = Max(array);
int min = Min(array);
Console.WriteLine($"{max} - {min}");
Console.WriteLine($"{max - min} разница между максимальным и минимальным элементами");

