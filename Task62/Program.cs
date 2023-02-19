// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetArray(int m,int n)
{
    int[,] result = new int[m,n];
    int a = 1;
  
   for (int j = 0; j < m-1; j++)
   {
    for (int i = 0+j; i < n-j; i++)
   {
    result[0 + j,i]= a;
    a++;
   }
   for (int i = 1+j; i < m-j; i++)
   {
     result[i,n-1-j]= a;
    a++;
   }
    for (int i = n-2-j; i >= 0+j; i--)
    {
        result[m-1-j,i] = a;
        a++;
    }
     for (int i = m-2-j; i > 0 + j; i--)
     {
        result[i,0+j] = a;
        a++;
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
            if (inArray[i,j] < 10)
            {
                Console.Write($"0{inArray[i, j]}\t ");
            }
            else
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] array = GetArray(4,4);
PrintArray(array);
