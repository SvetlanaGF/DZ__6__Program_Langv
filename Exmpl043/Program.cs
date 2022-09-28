// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
//Console.Write("Введите значение k1: ");
//Console.ReadLine(k1);
//Console.Write("значение b1: ");
//Console.ReadLine(b1);
//Console.Write("значение k2: ");
//Console.ReadLine(k2);
//Console.Write("значение b2: ");
//Console.ReadLine(b2);

double b1 = 2, k1 = 5, b2 = 4, k2 = 9;
double x;
double y;

if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");

else if (k1==k2) Console.WriteLine("Прямые параллельны");

else
{
x=(b2-b1)/(k1-k2);
y=(k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine($"x= {x}, y= {y}");
}

