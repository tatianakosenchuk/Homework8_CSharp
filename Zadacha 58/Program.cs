/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int Getnumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

int[,] GetRandomTable(int rows, int columns)
{
    int[,] table = new int[rows, columns];
    Random rnd = new Random();
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                table[i, j] = rnd.Next(1, 5);
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

int[,] MultiplyArrays(int[,] firstArray, int[,] secondArray)

{
    if (firstArray.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine(" Невозможно найти произведение разноразмерных матриц");
    }
    int[,] resultArray = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int z = 0; z < firstArray.GetLength(1); z++)
            {
                resultArray[i, j] += firstArray[i, z] * secondArray[z, j];
            }
        }
    }
    return resultArray;
}

int rows = Getnumber("Введите количество строк: ");
int columns = Getnumber("Введите количество столбцов: ");
Console.WriteLine("");
int[,] firstArray = GetRandomTable(rows, columns);
int[,] secondArray = GetRandomTable(rows, columns);
PrintTable(firstArray);
Console.WriteLine("");
PrintTable(secondArray);
Console.WriteLine("");
int[,] resultArray = MultiplyArrays(firstArray, secondArray);
PrintTable(resultArray);