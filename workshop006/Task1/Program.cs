// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

int m = Prompt ("Укажите количество чисел, которое необходимо ввести => ");
int [] numbers = new int [m];
int countPositive = 0;
for (int i=0; i < m; i++) 
{
    numbers [i] = Prompt ("Введите число => ");
    if (numbers [i] > 0) countPositive++;
}
printArray(numbers);
Console.WriteLine ("Количество чисел больше нуля равно "+ countPositive);
