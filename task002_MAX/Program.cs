// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7git remote add origin https://github.com/ansmir/Seminar1DZ.git
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a = 2;
int b = 10;

int max = a;

if (a > max) max = a;
if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);