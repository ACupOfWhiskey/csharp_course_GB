// Задача 2: Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.


string del_second_digit(int number)
{
    if ((-1000 < number && number < -99) || (number < 1000 && number > 99))
        return $"{number} -> {number / 100 * 10 + number % 10}";
    return "Number doesn't fit";
}
Console.WriteLine(del_second_digit(int.Parse(Console.ReadLine())));