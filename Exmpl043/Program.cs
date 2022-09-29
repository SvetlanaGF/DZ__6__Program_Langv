// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)

Console.Clear();
double [,] lines = { {5, 2}, { 9, 4}};
double x1;
double y1;

if ((lines[0,0] == lines[1,0]) && (lines[0,1] == lines[1,1])) 
{
    Console.WriteLine("Прямые совпадают");
}
else if (lines[0,0] == lines[1,0]) Console.WriteLine("Прямые параллельны");
else
{
    //x=(b2-b1)/(k1-k2)
    x1=(lines[1,1] - lines[0,1])/(lines[0,0] - lines[1,0]);
    //y=(k1*(b2-b1))/(k1-k2)+b1
    y1=(lines[0,0]*(lines[1,1] - lines[0,1]))/(lines[0,0] - lines[1,0])+lines[0,1];
    Console.WriteLine($"x= {x1}, y= {y1}");
}


double b1 = 2, k1 = 5, b2 = 4, k2 = 9;
double x, y;

if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");

else if (k1==k2) Console.WriteLine("Прямые параллельны");

else
{
x=(b2-b1)/(k1-k2);
y=(k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine($"x= {x}, y= {y}");
}

