// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt (string message)
{
    Console.WriteLine (message);
    string param = Console.ReadLine();
    return int.Parse (param);
}

int N = Prompt ("Введите число");
int index = 1;
int result = 1;
while (index <=N)
{
 Console.WriteLine (result= index*index*index);
 index++;
}
