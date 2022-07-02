// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

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

void FindElement (int [,] array, int i, int j) 
{   
    if (i>=array.GetLength(0) || j>=array.GetLength(1))
    {
        Console.WriteLine ("Такого элемента нет");
        Environment.Exit(9);
    }
    else 
    {
        Console.WriteLine($"Значение элемента равно {array[i, j]}");
    }    
}


int row = Prompt("Количество строк >");
int column = Prompt("Количество столбцов >");
int min = -10;
int max = 10;
int i = Prompt("Введите индекс i >");
int j = Prompt("Введите индекс j >");
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
FindElement (array, i, j);

