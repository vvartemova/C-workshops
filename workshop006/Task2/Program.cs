// Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int k1 = Prompt ("Введите значение k1 => ");
int b1 = Prompt("Введите значение b1 => ");
int k2 = Prompt("Введите значение k2 => ");
int b2 = Prompt("Введите значение b2 => ");

if (k1 == k2) 
{
    Console.WriteLine($"Прямые не пересекаются");
    Environment.Exit(9);
}
int x = (b2-b1)/(k1-k2);
int y = k1*x + b1;

Console.WriteLine ($"Прямые пересекаются в точке с координатами {x} ; {y}");
