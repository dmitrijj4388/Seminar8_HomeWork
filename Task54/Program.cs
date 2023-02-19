// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void SortRowArray(int[,] array, int a)
{
int temp ;
for (int i = 0; i < array.GetLength(1); i++)
 {
    for (int j = 0; j < array.GetLength(1) - 1; j++) 
    {
        if (array[a,j] < array[a,j + 1]) 
        {
            temp = array[a,j + 1];
            array[a,j + 1] = array[a,j];
            array[a,j] = temp;
        }
    }
}
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       SortRowArray(array,i); 
    }
}

Console.Clear();
int[,] matrix = GetArray(5,5,-10,10);
PrintArray(matrix);
Console.WriteLine();
SortArray(matrix);
PrintArray(matrix);