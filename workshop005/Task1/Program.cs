// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] InitArray(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(min, max + 1);
    }
    return arrA;
}


void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}

int CountEven (int [] array)
{
    int count = 0;
    for (int i=0; i <array.Length; i++)
    {
        if (array[i]%2 == 0) count++;
    }
    return count;
}

int [] newArray = InitArray(10, 100, 999);
PrintArray (newArray);
Console.WriteLine ($"Количество четных чисел в массиве равно {CountEven(newArray)}");
