// Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,...
// Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
//N = 12-> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}


void PrintNum(int N)
{
    int num = 1;
    int k = 0;
    for (int i = 1; i <= N; i++)
    {
        Console.Write(num + " ");
        k++;
        if (num == k)
        {
            k = 0;
            num = num + 1;
        }
    }

    return;
}
int N = Prompt("Введите N => ");
PrintNum(N);
Console.WriteLine();

