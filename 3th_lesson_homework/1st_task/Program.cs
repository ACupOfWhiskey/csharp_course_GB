// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Enter the number: ");
string number = Console.ReadLine();
int len = number.Length;
if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number}: the number is a palindrome");
    }
    else
    {
        Console.WriteLine($"{number}: the number is not a palindrome");
    }
}
else
{
    Console.WriteLine($"{number}: the number is not five digit");
}