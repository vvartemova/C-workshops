//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

int Prompt (string message)
{
    Console.WriteLine (message);
    string param = Console.ReadLine();
    return int.Parse (param);
}

int N = Prompt ("Введите пятизначное число");

if (N < 10000 || N > 99999) Console.WriteLine ("Неверный ввод числа");
else 
{
int param1 = N/10000;
int param2 = N/1000%10;
int param3 = N/100%10;
int param4 = N/10%10;
int param5 = N%10;
if (param1==param5 && param2==param4) 
{
   Console.WriteLine ("Число является палиндромом");
}
else Console.WriteLine ("Число не является палиндромом");
}
