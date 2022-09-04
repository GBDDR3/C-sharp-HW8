//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int n = 4;
int m = 4;
int[,] arrayA = new int[m, n];
int[] temp = new int[m];

int[,] FillArray(int m, int n)
{
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arrayA[i, j] = random.Next(1, 15);
        }
    }
    return arrayA;
}
int[,] result = FillArray(m, n);

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Print2dArray(result);
Console.WriteLine("Новый массив: ");
void SortArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            temp[j] = arrayA[i, j];
        }
        Array.Sort(temp);

        for (int k = 0; k < m; k++)
        {
            arrayA[i, k] = temp[k];
            Console.Write($"{arrayA[i, k]} ");
        }

        Console.WriteLine();
    }
}

SortArray(result);