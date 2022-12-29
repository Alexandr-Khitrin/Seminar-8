int m = ReadLine("Введите размер матрицы: ");
Console.WriteLine();
int[,] matrix = new int[m, m];

FillArraySpiral(matrix, m);
PrintArray(matrix);
void FillArraySpiral(int[,] array, int b)

{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < b * b; e++)
    {
        int a = 0;
        do { array[i, j++] = value++; } while (++a < b - 1);
        for (a = 0; a < b - 1; a++) array[i++, j] = value++;
        for (a = 0; a < b - 1; a++) array[i, j--] = value++;
        for (a = 0; a < b - 1; a++) array[i--, j] = value++;
        ++i; ++j;
        b = b < 2 ? 0 : b - 2;
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
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