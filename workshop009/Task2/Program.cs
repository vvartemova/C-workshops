// Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N с помощью рекурсии.


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int PrintSumNatural(int M, int N)
{
    if (M > N)
    {
        return 0;
    }

    return PrintSumNatural(M + 1, N) + M;

}
int M = Prompt("Введите M => ");
int N = Prompt("Введите N => ");
Console.WriteLine(PrintSumNatural(M, N));
