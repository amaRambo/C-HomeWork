// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int c = a;
int n = 0;
while (c > 0)
{
    c = c / 10;
    n++;
}
if (n >= 3)
{
    while (n - 3 > 0)
    {
        a = a / 10;
        n--;
    }
    Console.WriteLine(a % 10);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}






// if (a > 99)
// {
//     Console.WriteLine(a.ToString()[2]);
// }
// else
// {
//     Console.WriteLine("В заданном числе нет третьей цифры");
// }


