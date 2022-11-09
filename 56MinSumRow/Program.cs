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
    int[] arraySumRow = new int[inArray.GetLength(0)];    
    int sumRow = 0;
    for (int index = 0; index < arraySumRow.Length; index++)
    {        
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                sumRow += inArray[i, j];                                
            }
            arraySumRow[index] = sumRow;  
            sumRow = 0;          
        } 
        return arraySumRow;            
    }    
     
}

void FindMinSum (int[] sumsRows)
{
    int min = sumsRows[0];
    for (int i = 1; i < sumsRows.Length; i++)
    {        
        if (sumsRows[i] < min)
        min = sumsRows[i];        
        Console.WriteLine($"минимум: {min}");
    }    
}

Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetArray(row, col, 0, 10);
PrintArray(userArray);
Console.WriteLine();

int[] arraySums = SumRows(userArray);
Console.WriteLine(String.Join(" ", arraySums));
FindMinSum(arraySums);