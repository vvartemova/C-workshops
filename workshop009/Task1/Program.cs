//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
//в промежутке от M до N с помощью рекурсии


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintEven(int M, int N)
{
    if (M > N)
    {
        return;
    }

    if (M % 2 == 0)
    {
        Console.Write($"{M} ");
    }

    PrintEven(M + 1, N);

}
int M = Prompt("Введите M => ");
int N = Prompt("Введите N => ");
PrintEven(M, N);
Console.WriteLine();