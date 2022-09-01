using System;
// Задача 3:*(Дополнительная, не обязательная задача): Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)

Console.Clear();

Console.Write("Введите число `N`: ");
int amt = Int32.Parse(Console.ReadLine());
Random rnd = new Random();
int[] arr = new int[amt];

int createNum()
{
    int prod = 1;
    int sum = 0;
    int num = rnd.Next(0, 999999);
    int tempNum = num;

    while (tempNum != 0)
    {
        int dig = tempNum % 10;
        prod *= dig;
        sum += dig;
        tempNum = tempNum / 10;
    }
    return (prod % sum == 0) ? num : createNum();
}

for (int i = 0; i < amt; i++)
{
    arr[i] = createNum();
}

Console.WriteLine(String.Join("   ", arr));