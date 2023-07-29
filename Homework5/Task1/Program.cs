// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int FindCount (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        result += 1;
    }
    return result;
}

int[] GenArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i <= length - 1; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int[] array = GenArray(4, 100, 1000);
int count = FindCount(array);
Console.Write("[" + string.Join(",", array) + "] -> " + FindCount(array));