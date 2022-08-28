// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Fill(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);

        }
    }
    return arr;
}

int[,] Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],3}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return arr;
}

double Average(int[,] arr)
{
    double colAverage = 0;

    for (int col = 0; col < arr.GetLength(0); col++)
    {
        double colSum = 0;
        for (int str = 0; str < arr.GetLength(1); str++)
        {
            colSum += arr[col, str];
        }
        colAverage = Math.Round(colSum / arr.GetLength(1), 2);
        System.Console.WriteLine($"Average in {col + 1} column: {colAverage}");
    }
    return colAverage;
}

Average(Print(Fill(4, 6)));