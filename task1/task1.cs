// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()



void myFunc(double Base, int Expn)
{
    double res = 1;
    for (int i = 0; i < Expn; i++)
    {
        res *= Base;
    }
    Console.WriteLine(res);
}

Console.Write("Введите число:   ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень: ");
int B = Int32.Parse(Console.ReadLine());

myFunc(A, B);
