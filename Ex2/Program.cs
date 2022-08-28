// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Я не понял условие. Если разделять на позиции, то 17 - это 2 столбик, 7 строка??
// Буду делать исходя из этой логики :)

int[,] Fill(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 25);

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
            System.Console.Write($"{arr[i, j],5}");
        }
        System.Console.WriteLine();
    }
    return arr;
}

int Result(int[,] arr)
{
    System.Console.Write("Enter number for check: ");
    int checkNum = Convert.ToInt32(Console.ReadLine());

    int str = checkNum / 10;
    int col = checkNum % 10;

    if (col > arr.GetLength(0) && str > arr.GetLength(1))
        System.Console.WriteLine("N/A");
    else System.Console.WriteLine($"Element: {arr[col, str]}");

    return arr[col, str];
}

Result(Print(Fill(5, 6)));