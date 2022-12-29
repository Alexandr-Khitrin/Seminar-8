using System;

int m = ReadLine("Введите M ");
int n = ReadLine("Введите N ");
int[,] matrix = new int[m, n];
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinSumLine(matrix);


void MinSumLine(int [,] matrix)
{
    int minSum = 0;
    int indexRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
            if (i == 0)
            {
                minSum = sum;
            }
            else if (sum < minSum)
            {
                minSum = sum;
                indexRow = i + 1;
            }
    }
    Console.WriteLine($"Строка номер {indexRow}, содержит в себе наименьшую сумму элементов {minSum}");

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