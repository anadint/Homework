// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void GetCoordinates(int b1, int k1, int b2, int k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны и не пересекаются");   
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x};{y})");      
    }
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int b1 = GetInfo("Введите переменную b1: ");
int k1 = GetInfo("Введите переменную k1: ");
int b2 = GetInfo("Введите переменную b2: ");
int k2 = GetInfo("Введите переменную k2: ");
GetCoordinates(b1, k1, b2, k2);
