// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Prompt (string message)
{
    Console.Write (message);
    string param = Console.ReadLine();
    return int.Parse (param);
}

int Pow (int number, int index)
{
    int result = 1;
    for (int i=1; i<=index; i++)
      {
       result = result*number;
      }
    return result;
}
int paramA = Prompt ("Введите число А >> ");
int paramB = Prompt ("Введите число B >> ");
if (paramB > 0) Console.WriteLine ($"A в степени B равняется {Pow (paramA, paramB)}");
else Console.WriteLine("Ошибка: показатель степени (B) не является натуральным числом");