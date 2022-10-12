// Задача 3: Напишите программу, которая задаёт массив 
// из 8 случайных элементов и выводит их на экран.

int enter(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = enter("Введите длину массива: ");

int[] fiiiiiil(int number)
{
    int[] array = new int[number];
    for (int i = 0; i <= number - 1; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void Printer(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] array = fiiiiiil(number);
Printer(array);
