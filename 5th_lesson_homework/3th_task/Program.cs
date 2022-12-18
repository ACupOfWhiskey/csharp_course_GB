// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива


// Задаём входные данные, вводим массив, обозначаем, что нас интересуют вещественные числа
Console.WriteLine("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
RandomArray(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

// Задаём условие для определения максимального и минимального элементов в массиве
for (int num = 0; num < numbers.Length; num++)
{
    if (numbers[num] > max)
        {
            max = numbers[num];
        }
    if (numbers[num] < min)
        {
            min = numbers[num];
        }
}

// Вывод итоговых сообщений
Console.WriteLine($"Maximum value = {max}, minimum value = {min}");
Console.WriteLine($"Differences between the maximum and minimum value = {max - min}");


// Задаём функцию для определения рандомных чисел в массиве
void RandomArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

// Задаём функцию для вывода рандомных чисел в терминале
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
