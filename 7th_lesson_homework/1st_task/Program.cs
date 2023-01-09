// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами


Console.WriteLine("Enter the number of lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lines, columns];
RandomArray(numbers);
PrintArray(numbers);

void RandomArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
