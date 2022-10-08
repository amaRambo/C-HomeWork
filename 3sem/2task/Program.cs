// Задача 2: Напишите программу, которая принимает на вход координаты 
//           двух точек и находит расстояние между ними в 3D пространстве.


const int x = 0;
const int y = 1;
const int z = 2;
int enter(string msg)
{
    Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] inputPoint(int point)
{
    int[] answer = new int[3];
    answer[x] = enter($"ВВедите X{point}: ");
    answer[y] = enter($"ВВедите Y{point}: ");
    answer[z] = enter($"ВВедите Z{point}: ");
    return answer;
}
int Power2(int arg)
{
    return arg*arg;
}
int[] p1 = inputPoint(1);
int[] p2 = inputPoint(2);
double length = Math.Sqrt(Power2(p1[0] -p2[x]) + Power2(p1[y] - p2[y]) + Power2(p1[z] - p2[z]));
Console.WriteLine($"{length:f2}");
