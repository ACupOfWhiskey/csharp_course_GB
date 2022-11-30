// Задача 4: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.


void is_holiday(int number)
{
    string answer = "No, it's not a holiday";
    if (number == 6 || number == 7) answer = "Yes, it's a holiday";
    Console.WriteLine($"{number} -> {answer}");
}
is_holiday(int.Parse(Console.ReadLine()));