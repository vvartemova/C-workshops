// //Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
void PrintArray2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] FindSumRow(int[,] array)
{
    int[] newarray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i, j];
            newarray[i] = sumRow;
        }
    }
    return newarray;
}

int FindMin(int[] array)
{
    int min = array[0];
    int imin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            imin = i;
        }
    }
    return imin;
}

int row = Prompt("Количество строк прямоугольного массива >");
int column = Prompt("Количество столбцов прямоугольного массива >");
int min = -10;
int max = 10;
if (row == column)
{
    Console.WriteLine("Количество строк не должно равняться количеству столбцов");
    Environment.Exit(9);
}
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
Console.WriteLine();
int[] sumarray = FindSumRow(array);
PrintArray2(sumarray);
int imin = FindMin(sumarray);
Console.WriteLine($"Номер строки c наименьшей суммой элементов равен {imin + 1}");
