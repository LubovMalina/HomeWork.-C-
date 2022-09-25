// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");

int number = Convert.ToInt32(Console.ReadLine());
string number1 = Convert.ToString(number);

if (number1.Length > 2){
  Console.WriteLine("Третья цифра -" + number1[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}
