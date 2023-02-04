// Найти кубы чисел от 1 до N
void CubNumber(int num)
{
    for (int i = 1; i < num; i++)
    {
    Console.WriteLine($"{i}^2 = {i*i}");
    }
}

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());

CubNumber(num);