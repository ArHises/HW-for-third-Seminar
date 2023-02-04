// Найти кубы чисел от 1 до N

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i < num; i++)
{
    Console.WriteLine($"{i}^2 = {i*i}");
}

