// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

void PrintRandomArray (int [] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1001);
        Console.Write (array[i] + " ");
    
    }
    Console.WriteLine();
}
int [] randomArray = new int [8];
PrintRandomArray (randomArray);

