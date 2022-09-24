// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (99 < number && number < 1000)
{
    int g = (number/10)%10;
    Console.Write($"Вторая цифра {number} числа - {g}");
}
else
{
    Console.Write("Введите трехзначное число");
}