// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)

Console.Clear();
double[,] array = new double [2, 2];
double x1;
double y1;

void InputCoefficients (double arr)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0);j++)
    {
        if (i == 0 && j == 0) Console.Write("k1: ");
        else if (i == 0 && j == 1) Console.Write("b1: ");
            else if (i == 1 && j == 0) Console.Write("k2: ");
                else Console.Write("b2: ");
        array [i,j] = int.Parse(Console.ReadLine());
    }
}
}

void OutputCoefficients (double arr)
{
Console.WriteLine("Решим систему уравнений:");
Console.WriteLine("y = " + array[0,0] + " * x + " + array[0,1]);
Console.WriteLine("y = " + array[1,0] + " * x + " + array[1,1]);
}
InputCoefficients (array [0,0]);
Console.WriteLine();
OutputCoefficients (array [0,0]);
Console.WriteLine();

    //x=(b2-b1)/(k1-k2)
    x1 = (array[1, 1] - array[0, 1]) / (array[0, 0] - array[1, 0]);
    //y=(k1*(b2-b1))/(k1-k2)+b1
    y1 = (array[0, 0] * (array[1, 1] - array[0, 1])) / (array[0, 0] - array[1, 0]) + array[0, 1];
    Console.WriteLine($"Координты точки пересечения прямых: x= {x1}, y= {y1}\n");

