// Напишите программу, которая принимает на вход трехзначное число 
//и на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

int [] array = new int[3];
int index = array.Length - 1;

while (numberInt > 0)
{
array[index] = numberInt % 10;
numberInt = numberInt / 10;
index--;
}

Console.WriteLine (array [1]);


