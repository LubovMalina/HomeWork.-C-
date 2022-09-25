// // Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
// необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

Console.Clear();

Console.WriteLine("Введите значение радиуса круга, см: ");
double radius = double.Parse(Console.ReadLine());

double square =  Math.Round((Math.PI * Math.Pow(radius,2)),0);

Console.Write("Площадь круга равна ->");
Console.WriteLine(square);

double max = 0;
while (square !=0)
{
    double s = square % 10;
    if (s>max){
        max = s;   
    }
    square = square / 10;
}
double Max = Math.Round(max,0);
Console.WriteLine($"Максимальная цифра в числе  -> {Max}");
