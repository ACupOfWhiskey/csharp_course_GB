// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


string str_num1 = Console.ReadLine();
string str_num2 = Console.ReadLine();

int num1 = int.Parse(str_num1);
int num2 = int.Parse(str_num2);

if (num1 > num2)
{
    Console.Write($"max = {num1}, min = {num2}");
}
else if (num1 == num2)
{
    Console.Write($"{num1} = {num2}");
}
else
{
    Console.Write($"max = {num2}, min = {num1}");
}