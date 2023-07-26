// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int digit3 = num % 10;
if (num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
   Console.WriteLine($"Третья цифра числа {num} -> {digit3}"); 
}
