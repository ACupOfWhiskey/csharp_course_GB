// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет


Console.WriteLine("Enter line number: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter column number: ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
RandomArray(numbers);

if (line > numbers.GetLength(0) || column > numbers.GetLength(1))
{
    Console.WriteLine("There is no such element");
}
else
{
    Console.WriteLine($"Element value {line} of line and value {column} of column is equal {numbers[line-1,column-1]}");
}

PrintArray(numbers);

void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}