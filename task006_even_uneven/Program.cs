// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.Write("Enter your number: ");
int numbera = int.Parse(Console.ReadLine());

if (numbera % 2 == 0)
{
    Console.WriteLine("true");
}
else 
{
    Console.WriteLine("false");
}