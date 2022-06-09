//Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка)

Console.Write ("Введите число  - ");
string paramString = Console.ReadLine();
int paramInt = int.Parse (paramString);
int result = paramInt%2;

if (result == 0)
{
Console.WriteLine($"Число {paramInt} - четное");
} 
else 
{
    Console.WriteLine($"Число {paramInt} - нечетное");
    }





