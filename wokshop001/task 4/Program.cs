//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число  - ");
string paramString = Console.ReadLine();
int paramInt = int.Parse (paramString);
int i = 1;

while (i <= paramInt)
{ int result = i%2;
  if  (result == 0) 
  {
    Console.WriteLine(i);
  }
  i = i+1;
}
