//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Введите число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if (number.Length < 3) Console.WriteLine ("Третьей цифры нет");

else {
int [] array = new int[number.Length];
int index = array.Length - 1;

while (numberInt > 0)
{
array[index] = numberInt % 10;
numberInt = numberInt / 10;
index--;
}

Console.WriteLine (array [2]);
}

