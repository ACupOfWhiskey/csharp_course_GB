// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.


int number_A = ReadInt("Enter the number A: ");
int number_B = ReadInt("Enter the number B: ");
Exponentiation(number_A, number_B);


void Exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
