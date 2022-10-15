// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0


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

int[] array = CreateArray(10, 0, 999);
PrintArray(array);
Console.WriteLine();

int Amount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        count = count + array[i];
    }
    return count;
}

Console.WriteLine($"{Amount(array)} сумма элементов, стоящих не нечетных позициях");
