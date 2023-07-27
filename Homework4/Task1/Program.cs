// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetNumDegree(int numA, int numB)
{
    int num = 1;
    for (int i = 0; i < numB; i++)
    {
        num *= numA;
    }
    return num;
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int numA = GetInfo("Введите число A: ");
int numB = GetInfo("Введите число B: ");
int num = GetNumDegree(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {num}");
