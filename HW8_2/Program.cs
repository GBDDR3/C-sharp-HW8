// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.WriteLine("Введите число m: ");
bool numberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число n : ");
bool numberN = int.TryParse(Console.ReadLine(), out int n);
if (numberN == false || numberN == false)
{
    Console.WriteLine("Введены неправильные данные");
}


int[,] FillArray(int m, int n)
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
int index = 0;
int minsum = Int32.MaxValue;

void SumLine(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            index++;
        }

    }
 Console.WriteLine($"Индекс строки: {index}, сумма элементов: {minsum}");
}

SumLine(result);
