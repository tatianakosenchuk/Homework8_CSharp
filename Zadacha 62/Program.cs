/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void PrintTable(int[,] table)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        for (int columns = 0; columns < table.GetLength(1); columns++)
            if (table[rows, columns] < 10)
            {
                Console.Write($"0{table[rows, columns]} ");
            }
            else
            {
                Console.Write($"{table[rows, columns]} ");
            }
        Console.WriteLine();
    }
}

int[,] GetSpiraltable(int rows, int columns)
{
    int[,] table = new int[rows, columns];
    int element = 1;
    int i = 0;
    int j = 0;

    while (element <= rows * columns)
    {
        table[i, j] = element;
        if (i <= j + 1 && i + j < rows - 1)
            ++j;
        else if (i < j && i + j >= rows - 1)
            ++i;
        else if (i >= j && i + j > rows - 1)
            --j;
        else
            --i;
        ++element;
    }
    return table;
}

int[,] array = GetSpiraltable(4, 4);
PrintTable(array);