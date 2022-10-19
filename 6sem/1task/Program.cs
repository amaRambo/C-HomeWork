// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


string enter(string msg)
{
    Console.Write(msg);
    string number = Console.ReadLine();
    return number;
}

string a = " ";
int count = 0;

while (a != "")
{
    a = enter("ВВедите число: ");
    if (a == "")
    {
        break;
    }
    int b = Convert.ToInt32(a);
    if (b > 0)
    {
        count++;
    }
}

Console.WriteLine($"{count} положительных числа было введено");