//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write ("Введите число 1 - ");
string paramStringA = Console.ReadLine();
int paramIntA = int.Parse (paramStringA);
Console.Write ("Введите число 2 - ");
string paramStringB = Console.ReadLine();
int paramIntB = int.Parse (paramStringB);
Console.Write ("Введите число 3 - ");
string paramStringС = Console.ReadLine();
int paramIntС = int.Parse (paramStringС);
int max = paramIntA;

if (paramIntB > max) max = paramIntB;
if (paramIntС > max) max = paramIntС;
Console.WriteLine($"Максимальное число равно {max}");

