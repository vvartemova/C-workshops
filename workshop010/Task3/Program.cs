// Заполните спирально квадратный массив по возрастанию, с заданным размером


int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int N = Prompt ("Введите длинну стороны квадратного массива => ");
int[,] array = new int[N, N];
int iStart = 0;
int iEnd = 0;
int jStart = 0;
int jEnd = 0;
int k = 1;
int i = 0;
int j = 0;
array[i, j] = k;

while (k <= N * N)
{
    array[i, j] = k;
    if (i == iStart && j < N - jEnd - 1)
        j++;
    else if (j == N - jEnd - 1 && i < N - iEnd - 1)
        i++;
    else if (i == N - iEnd - 1 && j > jStart)
        j--;
    else
        i--;

    if ((i == iStart + 1) && (j == jStart) && (jStart != N - jEnd - 1))
    {
        iStart++;
        iEnd++;
        jStart++;
        jEnd++;
    }
    k++;
}

PrintArray(array);