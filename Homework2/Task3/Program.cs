// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Result ( int arg)
{
    if (arg == 6 || arg == 7)
    {
        Console.WriteLine($"{arg} -> да");
    }
    else
    {
        Console.WriteLine($"{arg} -> нет");
    }
}

Console.Write("Введите порядковый номер дня недели: ");
int num = int.Parse(Console.ReadLine());

Result(num);
