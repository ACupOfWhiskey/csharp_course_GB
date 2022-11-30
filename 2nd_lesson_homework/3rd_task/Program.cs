// Задача 3: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.


void only_third_digit(int number)
{
    Console.Write($"{number} -> ");
    if (number < 100)
    {
        Console.WriteLine("No third digit");
        return;
    }
    while (number > 999) number /= 10;
    Console.WriteLine(number % 10);
}
only_third_digit(int.Parse(Console.ReadLine()));