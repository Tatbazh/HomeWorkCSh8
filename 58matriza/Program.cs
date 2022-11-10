// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц
int[,] RandomGetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] MultipArray(int[,] arrayA, int[,] arrayB)
{
    if (arrayB.GetLength(0) != arrayA.GetLength(1)) //rowsB=columnsA; rowA=rowMult; colB=colMult
    {
        Console.WriteLine("Матрицы перемножить невозможно. Число строк матрицы №1 должно быть равно числу столбцов матрицы №2");
        return null;
    }
    else
    {
        int[,] multiArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];        
        for (int rowA = 0; rowA < arrayA.GetLength(0); rowA++)
        {
            for (int columnB = 0; columnB < arrayB.GetLength(1); columnB++)
            {
                multiArray[rowA, columnB] = 0;
                for (int rowB = 0; rowB < arrayB.GetLength(0); rowB++)
                {
                    multiArray[rowA, columnB] += arrayA[rowA, rowB] * arrayB[rowB, columnB];
                }
            }
        }
        return multiArray;
    }   
}

Console.Write("Введите количество строк для матрицы №1:");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для матрицы №1:");
int col1 = int.Parse(Console.ReadLine()!);
int[,] userArrayFirst = RandomGetArray(row1, col1, 0, 10);
PrintArray(userArrayFirst);
Console.WriteLine();

Console.Write("Введите количество строк для матрицы №2:");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для матрицы №2:");
int col2 = int.Parse(Console.ReadLine()!);
int[,] userArraySecond = RandomGetArray(row2, col2, 0, 10);
PrintArray(userArraySecond);
Console.WriteLine();


int[,] arrayResult = MultipArray(userArrayFirst, userArraySecond);
if (arrayResult != null) 
{
    Console.WriteLine("Произведение матрицы №1 и №2: ");
    PrintArray(arrayResult);
}
