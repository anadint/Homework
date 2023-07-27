// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int num)
{
    int result = 0;
    for (int i = 0; i < num; i++)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
    
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {num} равна {GetSum(num)}");