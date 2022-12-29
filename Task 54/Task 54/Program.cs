
int m = ReadLine("Введите M ");
int n = ReadLine("Введите N ");
int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine();

Console.WriteLine("Массив до изменений");

PrintArray(matrix);
Console.WriteLine();
OrderArray(matrix);
Console.WriteLine("Упорядоченный массив");
PrintArray(matrix);

void OrderArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
                if (matrix[i, z] < matrix[i, z + 1])
                {
                    int temp = 0;
                    temp = matrix[i, z];
                    matrix[i, z] = matrix[i, z + 1];
                    matrix[i, z + 1] = temp;
                }
            }
        }
    }
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}

int ReadLine(string input)
{
    Console.Write(input);
    int output = int.Parse(Console.ReadLine()!);
    return output;
}

