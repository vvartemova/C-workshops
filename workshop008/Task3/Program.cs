// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
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

int[,] CalcMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum = sum + matrixA[i, k] * matrixB[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}


int rowA = Prompt("Число строк первой матрицы >");
int columnA = Prompt("Число столбцов первой матрицы >");
int rowB = Prompt("Число строк второй матрицы >");
int columnB = Prompt("Число столбцов второй матрицы >");

int min = -10;
int max = 10;
if (columnA != rowB)
{
    Console.WriteLine("Количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы");
    Environment.Exit(9);
}
int[,] arrayA = GenerateArray(rowA, columnA, min, max);
PrintArray(arrayA);
Console.WriteLine();
int[,] arrayB = GenerateArray(rowB, columnB, min, max);
PrintArray(arrayB);
Console.WriteLine();
int[,] resultarray = CalcMatrix(arrayA, arrayB);
PrintArray(resultarray);

