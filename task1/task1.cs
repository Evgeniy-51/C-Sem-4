// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()

Console.Clear();

double myPow(double a, int b)
{
    double res = 1;
    for (int i = 0; i < b; i++)
    {
        res *= a;
    }
    return res;
}

Console.Write("Введите число:   ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень: ");
int B = Int32.Parse(Console.ReadLine());

Console.WriteLine(myPow(A, B));
