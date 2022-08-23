//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Clear();
Console.WriteLine("Веведите 2 числа:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
if (a > b)
{
Console.WriteLine(a);
}
if (b > a)
{
Console.WriteLine(b);
}
