/*2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3  */

Console.Clear();
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());

Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

int max = a;
if(max < b)
{
    max = b;
    Console.Write($"Максимальное число b = {b}, минимальное число a = {a}");
}else
{
    max = a;
    Console.Write($"Максимальное число a = {a}, минимальное число b = {b}");
}