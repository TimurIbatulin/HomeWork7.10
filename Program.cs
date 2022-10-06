//tanislav N: Необходимо найти 5 целых чисел (положительных), которые будут удовлетворять такому условиюx^5 + y^5 + z^5 + q^5 = w^5Т.е. сумма 4 чисел в пятой степени = 5 числу



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void CreateArray(double[,] array, int m, int n)
{
    //double [,] array = new double [m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble()*100;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

// Console.Write("Введите количество строк в массиве - ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите количество столбцов в массиве - ");
// int x = Convert.ToInt32(Console.ReadLine());
// double [,] arr = new double [z, x];
// CreateArray(arr, z, x);
// PrintArray(arr);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк в массиве - ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов в массиве - ");
int x = Convert.ToInt32(Console.ReadLine());
double [,] arr = new double [z, x];
CreateArray(arr, z, x);
Console.Write($"Введите номер строки в пределах чисел от 1 до {z} - ");
int q = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца в пределах чисел от 1 до {x} - ");
int w = Convert.ToInt32(Console.ReadLine());
PrintArray(arr);
int r=q-1;
int t=w-1;
if (r<z && t<x)
{
    Console.Write($"В строке номер {q}, столбце номер {w} распологается число {arr[r,t]}");
}
else
{
    Console.Write($"ОШИБКА!!!! Указанный адрес выходит за диапазон массива");
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.