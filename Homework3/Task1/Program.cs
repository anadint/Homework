// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void IsPalindrome(int num)
{
    if (num>9999 && num<100000)
    {
        if((num/10000 == num%10) && ((num/1000)%10 == (num%100)/10))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
    else
    {
        Console.WriteLine("Это число не пятизначное");
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Введите пятизначное число: ");
IsPalindrome(num);

// Console.Clear();
// Console.WriteLine("Введите пятизначное число: ");
// int A = int.Parse(Console.ReadLine());
// if (A>9999 && A<100000)
// {
//    if((A/10000 == A%10) && ((A/1000)%10 == (A%100)/10))
//    {
//        Console.WriteLine("Да");
//    }
//    else
//    {
//        Console.WriteLine("Нет");
//    }
// }
// else
// {
//    Console.WriteLine("Это число не пятизначное");
// }