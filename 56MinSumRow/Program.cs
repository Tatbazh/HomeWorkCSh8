// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
int[,] GetArray(int m, int n, int minValue, int maxValue)
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

int[] SumRows(int[,] inArray)
{
    int[] arraySums = new int[inArray.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        arraySums[i] = sum;
    }
    return arraySums;
}

int FindMinInArray(int[,] inArray) //находим мин сумму сразу, без выведения промежуточных
{    
    int sum = 0;
    int minSum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if (minSum > sum || minSum == 0)
        {
            minSum = sum;
        }
    }
    return minSum;
}

void FindMinSum(int[] sumsRows)
{
    int min = sumsRows[0];
    int index = 0;
    for (int i = 1; i < sumsRows.Length; i++)
    {
        if (sumsRows[i] < min)
        {
            min = sumsRows[i];
            index = i;
        }
    }
    Console.WriteLine($"№ строки с наименьшей суммой элементов: {index}");
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetArray(row, col, 0, 10);
PrintArray(userArray);
Console.WriteLine();

int[] arraySums = SumRows(userArray);
Console.WriteLine($"Суммы строк массива: {String.Join(" ", arraySums)}");
FindMinSum(arraySums);
//Console.WriteLine(FindMinInArray(userArray));

