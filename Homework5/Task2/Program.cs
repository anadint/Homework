// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int FindCount (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1) 
        result += array[i];
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

int[] array = GenArray(4, -99, 100);
int count = FindCount(array);
Console.Write("[" + string.Join(",", array) + "] -> " + FindCount(array));