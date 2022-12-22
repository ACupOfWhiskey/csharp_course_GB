// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// Пример: 0, 7, 8, -2, -2 -> 2


Console.Write("Enter numbers separated by commass: ");
int[] numbers = BuildArray(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}


Console.WriteLine();
Console.WriteLine($"Number of values greater than 0 = {sum}");


int[] BuildArray(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string text = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            text += input [i].ToString();
            i++;
        }
        else
        {
            text += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(text);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
