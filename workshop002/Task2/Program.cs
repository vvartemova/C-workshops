// Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа


int numberInt = new Random().Next (100, 1000);
Console.WriteLine (numberInt);   

int [] array = new int[3];
int index = array.Length - 1;

while (numberInt > 0)
{
array[index] = numberInt % 10;
numberInt = numberInt / 10;
index--;
}


Console.Write (array [0]);
Console.WriteLine (array [2]);

