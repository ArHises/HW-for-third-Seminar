﻿// Подсчитать сумму цифр в числе

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());

int sum = 0;
while (num > 0)
{
    sum = sum + (num % 10);
    num = num / 10;
}
Console.WriteLine("Sum =" + sum);