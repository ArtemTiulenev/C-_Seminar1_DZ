//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Clear();
Console.WriteLine("Веведите 3 числа:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
if (a > b && a >c )
{
Console.WriteLine(a);
}
if (b > a && b > c)
{
Console.WriteLine(b);
}
if (c > a && c > b)
{
Console.WriteLine(c);
}
