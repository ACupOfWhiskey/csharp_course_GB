// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


int num1 = int.Parse(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.Write($"{num1} is even");
}
else
{
    Console.Write($"{num1} is odd");
}