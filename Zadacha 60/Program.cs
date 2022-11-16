/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int Getnumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

int[,,] Get3DTable(int x, int y, int z)
{
    int[,,] table = new int[x, y, z];
    {
        int[] temp = new int[table.GetLength(0) * table.GetLength(1) * table.GetLength(2)];
        int element;
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 100);
            element = temp[i];
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (temp[i] == temp[j])
                    {
                        temp[i] = new Random().Next(10, 100);
                        j = 0;
                        element = temp[i];
                    }
                    element = temp[i];
                }
            }
        }
        int count = 0;
        for (int a = 0; a < table.GetLength(0); a++)
        {
            for (int b = 0; b < table.GetLength(1); b++)
            {
                for (int c = 0; c < table.GetLength(2); c++)
                {
                    table[a, b, c] = temp[count];
                    count++;
                }
            }
        }
    }
    return table;
}

void Print3DTable(int[,,] table)
{
    for (int x = 0; x < table.GetLength(0); x++)
    {
        for (int y = 0; y < table.GetLength(1); y++)
        {

            for (int z = 0; z < table.GetLength(2); z++)
            {
                Console.Write($"{table[x, y, z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.WriteLine($"Введите размер трехмерного массива: ");
int x = Getnumber("Введите x: ");
int y = Getnumber("Введите y: ");
int z = Getnumber("Введите z: ");
Console.WriteLine($"");
int[,,] array = Get3DTable(x, y, z);
Print3DTable(array);