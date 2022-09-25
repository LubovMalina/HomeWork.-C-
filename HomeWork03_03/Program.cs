// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int step = 1;

while (step < number + 1)
{
    double cub = Math.Pow(step,3);
    Console.WriteLine(cub);
    step++;
}
