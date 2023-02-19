/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30    */ 
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int getSumOfNumbers(int M,int N)
{
    if(N == M)
    {
        return M;
    }
    
    return M + getSumOfNumbers (M + 1, N);   
}
int M = GetDataFromUser("Введите число M");
int N = GetDataFromUser("Введите число N");
int SumOfNumbers = getSumOfNumbers(M,N);
Console.WriteLine (SumOfNumbers);