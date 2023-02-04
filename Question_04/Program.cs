// Показать кубы чисел, заканчивающихся на четную цифру

void SquerEvenNumber(int number)
{
    for (int i = 0; i < number; i = i + 2)
    {
        Console.WriteLine($"{i}^2 = {i*i}");
    }
}

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

SquerEvenNumber(number);