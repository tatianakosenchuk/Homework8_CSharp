/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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


int RowNumberMinSum(int[,] table)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    return minSumRow;
}


int[,] matrix = GetRandomTable(3, 4);
PrintTable(matrix);
int minimum = RowNumberMinSum(matrix);
Console.WriteLine($"наименьшая сумма элементов в {minimum + 1} строке");
Console.WriteLine();