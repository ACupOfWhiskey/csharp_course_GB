// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.


string second_digit(int number)
{
    if ((-1000 < number && number < -99) || (number < 1000 && number > 99))
        return $"{number / 10 % 10}";
    return "Number doesn't fit";
}
Console.WriteLine(second_digit(int.Parse(Console.ReadLine())));