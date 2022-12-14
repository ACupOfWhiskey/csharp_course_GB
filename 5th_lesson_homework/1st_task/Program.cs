// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве


// Задаём входные данные, вводим массив
Console.WriteLine("Enter the size of the array:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomArray(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);

// Задаём счётчик для определения чётных чисел
int count = 0;
for (int num = 0; num < numbers.Length; num++)
if (numbers[num] % 2 == 0)
count++;

// Вывод итогового сообщения
Console.WriteLine($"Total {numbers.Length} numbers, {count} of them are even");


// Функция для рандомного определения трёхзначных чисел в массиве 
void RandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

// Функция для вывода в терминал рандомных чисел массива
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
