// Написать программу вычисления произведения чисел от 1 до N

void SquerNum(int number)
{
    for (int i = 1; i <= number; i++)
    {
        for (int j = 1; j <= number; j++)
        {
            Console.WriteLine($"{i} x {j} = {i*j}");
        }
        Console.WriteLine();
    }

}
Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

SquerNum(number);