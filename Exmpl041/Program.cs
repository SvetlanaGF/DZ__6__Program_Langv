// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

void InputArray (int [] arrInput)
{
    for (int i=0; i<arrInput.Length; i++)
    {
        Console.Write($"{i}:  ");
        arrInput[i] = int.Parse(Console.ReadLine());
    }
}

static void OutputArray (int[] arrOutput, int i=0)
{   
    Console.Write($"{arrOutput[i]}");
    i = i+1;
    if (i < arrOutput.Length)  //Условие выхода из рекурсии
    {
        if (i<=arrOutput.Length) 
            {
                Console.Write(", ");
            }
        OutputArray (arrOutput, i);
    }
}

//int [] arrayExmpl = {0, 7, 8, -2, -2};
void MetodAboveZero (int [] arr, ref int i, ref int aboveZero)
{
        if (arr [i] > 0) 
        {
            aboveZero = aboveZero + 1;
            i++;
        }
        else 
        { 
            i++;
            if (i < arr.Length)
            {
                MetodAboveZero (arr, ref i, ref aboveZero);
            }
        }
}

Console.Write("\nВведите количество элементов массива:  ");
int countArray = int.Parse(Console.ReadLine());
int [] array = new int [countArray];

InputArray (array);
Console.Write($"[ ");
OutputArray (array);
Console.WriteLine(" ]");
int aboveZero = 0;
int i = 0;
while (i < array.Length)
{
    MetodAboveZero (array, ref i, ref aboveZero);
}
Console.WriteLine($"В этом массиве элементов больше 0 - {aboveZero}\n");