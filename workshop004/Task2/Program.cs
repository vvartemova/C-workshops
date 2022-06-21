// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt (string message)
{
    Console.Write (message);
    string param = Console.ReadLine();
    return int.Parse (param);
}

int CountDigit (int n)
{
    int i = 0;
    while (n>0)
    {
        n = n/10;
        i++;
    }
    return i;
}

int number = Prompt ("Введите число >> ");
int length = CountDigit (number);

int [] array = new int[length];
int i = array.Length - 1;
int sum = 0;

while (number > 0)
{
    array[i] = number%10;
    number = number/10;
    sum = sum + array [i];
    i--;
}

Console.WriteLine($"Cумма цифр равна {sum}");
