//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Clear();
Console.WriteLine("Веведите число для проверки на четность:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(a % 2==0 ? "Четное" : "Нечетное");
