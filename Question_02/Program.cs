// Подсчитать сумму цифр в числе

void SumChar(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    Console.WriteLine("Sum =" + sum);
}

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());

SumChar(num);