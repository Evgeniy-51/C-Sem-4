// Задача 2:* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. (для получения цифр числа операцию приведения числа к строке не использовать)

Console.Clear();

Console.Write("Введите число:   ");
int num = Int32.Parse(Console.ReadLine());
int tempNum = num;
int resSum = 0;

while (tempNum != 0)
{
    int dig = Math.Abs(tempNum % 10);
    if (dig != 0 && num % dig == 0) resSum += dig;
    tempNum = tempNum / 10;
}
Console.WriteLine(resSum);