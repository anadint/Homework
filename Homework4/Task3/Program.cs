// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void MassGen(int length, int minValue, int maxValue)
{
    int[] Array = new int[length];
    Console.Write($"Массив из {length} элементов - [");
    for (int i = 0; i < length-1; i++)
    {
        Array[i] = new Random().Next(minValue,maxValue);
        Console.Write(Array[i] + ", ");
    }
    Array[length-1] = new Random().Next(minValue,maxValue);
    Console.Write(Array[length-1] + "]");
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int length = GetInfo("Введите длину массива: ");
int min = GetInfo("Введите начальное значение диапазона: ");
int max = GetInfo("Введите конечное значение диапазона: ");
MassGen(length, min, max);

