// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
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



int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int length = array2.GetLength(1);
    int[,] multiMatrix = new int[array1.GetLength(0),array2.GetLength(1)];
    if(array1.GetLength(1) != array2.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");
    else
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                for (int n = 0; n < length-1; n++)
                {
                    multiMatrix[i,j] += array1[i,n] * array2[n,j];
                }
            }
        }
        
    }
    return multiMatrix;
    
}

Console.Clear();
int[,] matrix1 = GetArray(3, 2, 0, 5);
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = GetArray(2,3,0,5);
PrintArray(matrix2);
Console.WriteLine();
int[,] result = MultiplicationMatrix(matrix1, matrix2);
PrintArray(result);