// Задача 3: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

int enter(string msg)
{
    Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int N = enter("Введите число: ");
for (int ii = 1; ii <= N; ii++)
{
    Console.Write($"{Math.Pow(ii,3)}, ");
}