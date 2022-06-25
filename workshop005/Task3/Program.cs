// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] InitArray(int len, int min, int max)
{
    Random rnd = new Random();
    double [] arrA = new double [len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(min, max + 1);
    }
    return arrA;
}


void PrintArray(double[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        double element = arrA[i];
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}
double diffMaxMin(double[] array)
{   int i = 0;
    double max = array[i];
    double min = array[i];
    for (i = 0; i < array.Length; i++)
    {    
        if (array[i] > max) max = array [i];
        if (array[i] < min) min = array [i];
    }
    double result = max - min;
    return result;
}

double [] newArray = InitArray(10, 1, 10);
PrintArray(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива  равна {diffMaxMin(newArray)}");