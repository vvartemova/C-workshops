// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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

int CalcSumOddPosition (int [] array)
{
    int result = 0;
    for (int i=0; i<array.Length; i=i+2) 
    {
      result = result + array[i];
    
    }
           
    return result;
}

int[] newArray = InitArray(7, 1, 100);
PrintArray(newArray);
Console.WriteLine($"Сумма чисел на нечетных позициях равна {CalcSumOddPosition(newArray)}");