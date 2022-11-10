﻿// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
int[,,] RandomGetArray(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, l];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($"элемент массива: {inArray[i, j, k]}; его индекс: {i} {j} {k}");
            }
        }Console.WriteLine();        
    }
}

Console.Write("Введите количество строк в плоскости X:");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в плоскости Y:");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в плоскости Z:");
int z = int.Parse(Console.ReadLine()!);
int[,,] array3D = RandomGetArray(x, y, z, 10, 99);
PrintArray(array3D);
Console.WriteLine();