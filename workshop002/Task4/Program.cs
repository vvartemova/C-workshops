//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели и проверяет, является ли этот день выходным"
Console.Write("Введите цифру дня недели: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if (numberInt == 6 || numberInt==7 ) Console.WriteLine ("Да");
else Console.WriteLine ("Нет");