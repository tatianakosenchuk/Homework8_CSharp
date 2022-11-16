/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] GetRandomTable(int rows, int columns)
{
    int[,] table = new int[rows, columns];
    Random rnd = new Random();
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                table[i, j] = rnd.Next(0, 10);
        }
    }
    return table;
}
void PrintTable(int[,] table)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        for (int columns = 0; columns < table.GetLength(1); columns++)
        {
            Console.Write($"{table[rows, columns]}  ");
        }
        Console.WriteLine();
    }
}

int[,] SortTableRows(int[,] table)
{
    int[,] newtable = table;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int m = 0; m < table.GetLength(1) - 1; m++)
            {
                if (table[i, m] < table[i, m + 1])
                {
                    int temp = newtable[i, m + 1];
                    newtable[i, m + 1] = newtable[i, m];
                    newtable[i, m] = temp;
                }
            }
        }
    }
    return newtable;
}

int[,] matrix = GetRandomTable(3, 4);
PrintTable(matrix);
Console.WriteLine();
int[,] sortedtable = SortTableRows(matrix);
PrintTable(sortedtable);
Console.WriteLine();