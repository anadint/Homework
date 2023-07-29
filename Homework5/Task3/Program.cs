// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double GetMax(double[] array)
{
   double max = array[0];
   for(int i = 1; i < array.Length; i++)
   {
       if (max < array[i])
           max = array[i];
   }
   return max;
}

double GetMin(double[] array)
{
   double min = array[0];
   for(int i = 1; i < array.Length; i++)
   {
       if (min > array[i])
           min = array[i];
   }
   return min;
}

double[] GenArray(int length, double minValue, double maxValue)
{
    double[] array = new double [length];
    for (int i = 0; i <= length - 1; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        array[i] = Math.Round(array[i],2);
    }
    return array;
}

double [] array = GenArray(5, 0.00, 100.0);
double max = GetMax(array);
double min = GetMin(array);
double diff = Math.Round(max-min,2);
Console.Write("[" + string.Join(", ", array) + "] -> ");
Console.WriteLine($"{max} - {min} = {diff}");
