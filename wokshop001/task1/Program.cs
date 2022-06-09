//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write ("Введите число 1 - ");
string paramStringA = Console.ReadLine();
int paramIntA = int.Parse (paramStringA);
Console.Write ("Введите число 2 - ");
string paramStringB = Console.ReadLine();
int paramIntB = int.Parse (paramStringB);

if (paramIntA > paramIntB) 
{ 
    Console.WriteLine ($"Большее число - {paramIntA}");
    Console.WriteLine ($"Меньшее число - {paramIntB}");
}
else 
{   Console.WriteLine ($"Большее число - {paramIntB}");
    Console.WriteLine ($"Меньшее число - {paramIntA}");

}

