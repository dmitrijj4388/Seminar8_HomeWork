// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool CheckArray(int[,,] array, int number)
{
    bool check = false;
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
             if (array[i, j, k] == number)
             {
                check = true;
             }
            }
        }
    }
    return check;
}

int[,,] GetArray(int m, int n,int b, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, b];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < b; )
            {
                int temp = new Random().Next(minValue, maxValue+1);
                bool checkArr = CheckArray(result, temp);
                if(!checkArr)
                {
                    result[i, j, k] = temp;
                    k++;
                }
            }
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
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) \t ");
            }
           Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,,] array = GetArray(2,2,2,10,100);
PrintArray(array);