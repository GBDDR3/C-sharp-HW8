// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число A: ");
bool numberN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите число A1 : ");
bool numberM = int.TryParse(Console.ReadLine(), out int m);


if (numberN == false || numberM == false)
{
    Console.WriteLine("Введены неправильные данные");
}

int[,] FillArray(int n, int m)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(1,5);
        }
    }
    return array;
}
int[,] matrix = FillArray(n, m);

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
Print2dArray(matrix);

int[,] FillSecondArray(int n, int m)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(15);
        }
    }
    return array;
}
int[,] matrix2 = FillSecondArray(n, m);

Print2dArray(matrix2);

int[,] CompositionMatrix(int[,] array, int[,] array2)
{
    int[,] array3 = new int[m, n];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array3[i, j] += array[i, j] * array2[i, j];
            }
        }

    }
    return array3;
}

int [,] finishResult = CompositionMatrix(matrix, matrix2);

Print2dArray(finishResult);
