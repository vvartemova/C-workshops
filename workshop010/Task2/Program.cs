// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2->A(m, n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;

    if (n == 0) return FunctionAkkerman(m - 1, 1);

    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

int m = Prompt("Введите m => ");
int n = Prompt("Введите n => ");
if (m < 0 || n < 0)
{
    Console.WriteLine("Вычисление невозможно");
    Environment.Exit (13);
}
Console.WriteLine(FunctionAkkerman(m, n));