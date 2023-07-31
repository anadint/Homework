// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintAvr(int[,] array)
{
     for (int j = 0; j < array.GetLength(1); j++)
    {
        double avr = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avr = avr + array[i, j];
        }
        avr = avr / array.GetLength(0);
        Console.Write(Math.Round(avr,1) + "; ");
    }
    Console.WriteLine();
}

void PrintArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
          result[i, j] = new Random().Next(minValue, maxValue + 1);  
        }
    }
    return result;
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int rows = GetInfo("Введите количество строк: ");
int columns = GetInfo("Введите количество столбцов: ");
int[,] array= FillArray(rows, columns, 0, 9);
PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintAvr(array);