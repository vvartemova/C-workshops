// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void CalcAvgColumn(int[,] array)
{   
    double avgColumn = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {  
        double columnSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columnSum = columnSum + array [i,j];
            
            
        }
        avgColumn = columnSum / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое элеменов в столбце {j} равно {avgColumn:f2}");
    
    }

} 


int row = Prompt("Количество строк >");
int column = Prompt("Количество столбцов >");
int min = -10;
int max = 10;

int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
CalcAvgColumn (array);

