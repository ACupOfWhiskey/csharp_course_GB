// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях


// Задаём входные данные, вводим массив
Console.WriteLine("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomArray(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);

// Задаём условие, что нас интересуют числа, стоящие на нечётных позициях, определяем их количество
int sum = 0;
for (int num = 0; num < numbers.Length; num+=2)
    sum = sum + numbers[num];

// Вывод итогового сообщения
Console.WriteLine($"Sum of elements in odd positions = {sum}");


// Функция для рандомного определения чисел в массиве в диапазоне от 1 до 100
void RandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,100);
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
