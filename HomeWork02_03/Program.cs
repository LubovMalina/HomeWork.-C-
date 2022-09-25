// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите число: ");
double number = double.Parse(Console.ReadLine());

if (0 < number && number < 8)
{
    if (number == 1 ){
        Console.WriteLine("Нет. Плохая новость, друг, это - ПОНЕДЕЛЬНИК"); 
    }
    else if (number ==2 ){
        Console.WriteLine("Нет. Это всего лишь Вторник, Карл!");
    }
    else if (number ==3 ){
        Console.WriteLine("Нет, но он равноудален от надежд и от разочерований. Что за день недели?? СРЕДА");
    }
    else if (number ==4 ){
        Console.WriteLine("Нет. Псссс парень, а ты не шутишь? Ведб сегодня ЧЕТВЕРГ");
    }
    else if (number ==5 ){
        Console.WriteLine("Нет, но что может быть лучше вечера ПЯТНИЦЫ");
    }
    else if (number ==6 ){
        Console.WriteLine("Да. Это очешуительно!!! Сегодня выходной - СУББОТА");
    }
    else if (number ==7 ){
        Console.WriteLine("Да выходной, но завтра на работу! Чуешь чем пахнет? - ВОСКРЕСЕНЬЕМ");
    } 
}
else
{
    Console.WriteLine("Не умничай парень, введи цифру от 1 до 7"); 
}
