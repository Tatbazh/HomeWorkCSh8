// Задача 62: Заполните спирально массив 4 на 4.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    int sortedsize = 0;
    int row = 0;
    int column = 0;

    while (minValue < m * n)
    {
        while (column < n - sortedsize)  // слева направо
        {
            result[row, column] = minValue++;
            column++;
        }
        column = n - sortedsize - 1;
        row = sortedsize +1;
        while (row < m - sortedsize) // сверху вниз
        {
            result[row, column] = minValue++;
            row++;
        }
        column = n - sortedsize - 2;
        row = m - 1 - sortedsize;
        while (column > sortedsize - 1) // справа налево
        {
            result[row, column] = minValue++;
            column--;
        }
        column = sortedsize;
        row = m - sortedsize - 2;
        while (row > sortedsize)
        {
            result[row, column] = minValue++;
            row--;
            sortedsize++;
        }
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

int[,] userArray = GetArray(4, 4, 1, 16);
PrintArray(userArray);
Console.WriteLine();