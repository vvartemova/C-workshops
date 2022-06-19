// /Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

int Prompt (string message)
{
    Console.WriteLine (message);
    string param = Console.ReadLine();
    return int.Parse (param);
}

int X1 = Prompt ("Введите X1");
int Y1 = Prompt ("Введите Y1");
int Z1 = Prompt ("Введите Z1");
int X2 = Prompt ("Введите X2");
int Y2 = Prompt ("Введите Y2");
int Z2 = Prompt ("Введите Z2");

double result = Math.Sqrt ((X2-X1)*(X2-X1) + (Y2-Y1)*(Y2-Y1) + (Z2-Z1)*(Z2-Z1));
Console.WriteLine ("Расстояние между двумя точками в 3D пространстве " + result);

