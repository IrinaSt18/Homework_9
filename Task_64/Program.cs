/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"   */ 
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
string getRange(int N)
{
    if (N == 1)
    {
        return N + "";
    }
    return N + "," + getRange(N - 1);
}
int N = GetDataFromUser("Введите число N");
string range = getRange(N);
Console.WriteLine(range);

