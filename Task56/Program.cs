// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int SummRowMatrix(int[,] array, int a)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = sum + array[a,i];
    }
    return sum;
}

int IndexMinElement(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
         if(array[i] < min)
        {
            min = array[i];
            indexMin = i;
        }
    }

    return indexMin;
}

void RowMinSumMatrix(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumRow[i] = SummRowMatrix(array,i);  
    }
    int min = IndexMinElement(sumRow) + 1;
    System.Console.WriteLine($"Строка с минимальной суммой элементов - {min}");
    // Console.WriteLine(String.Join(" ",sumRow));
}

Console.Clear();
int[,] matrix = GetArray(6,3,0,2);
PrintArray(matrix);
RowMinSumMatrix(matrix);