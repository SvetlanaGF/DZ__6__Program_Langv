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

void OutputArray (int[] arrOutput)
{  
    Console.WriteLine($"\nСформирован массив из {arrOutput.Length} элементов.");
    Console.Write($"[ ");

    for (int i=0; i<arrOutput.Length; i++)
    {
        Console.Write($"{arrOutput[i]}");
        if (i<(arrOutput.Length-1)) Console.Write(", ");
    }
    Console.WriteLine(" ]");
}

void MetodAboveZero (int [] arr)
{
    int aboveZero = 0;
    for (int i=0; (i < arr.Length); i++)
    {
       if (arr [i] > 0) aboveZero += 1;
    } 
Console.Write($"В нём элементов больше 0 - {aboveZero}\n");
}

// 0, 7, 8, -2, -2 -> 2
int [] arrayExmpl1 = {0, 7, 8, -2, -2};
OutputArray (arrayExmpl1);
MetodAboveZero (arrayExmpl1); 

// 1, -7, 567, 89, 223-> 3
int [] arrayExmpl2 = {1, -7, 567, 89, 223};
OutputArray (arrayExmpl2);
MetodAboveZero (arrayExmpl2); 

Console.Write("\nВведите количество элементов массива:  ");
int countArray = int.Parse(Console.ReadLine());
int [] array = new int [countArray];
InputArray (array);
OutputArray (array);
MetodAboveZero (array);
Console.WriteLine();