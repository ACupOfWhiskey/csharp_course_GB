// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N


Console.WriteLine("Enter initial number M:");
int number_M = int.Parse(Console.ReadLine());

Console.WriteLine("Enter initial number N:");
int number_N = int.Parse(Console.ReadLine());

void SumOfNumbers (int number_M, int number_N, int sum)
{
    if (number_M > number_N) 
    {
        Console.WriteLine($"The sum of natural elements in the range from M to N: {sum}"); 
        return;
    }
    sum = sum + (number_M++);
    SumOfNumbers(number_M, number_N, sum);
}

SumOfNumbers(number_M, number_N, 0);
