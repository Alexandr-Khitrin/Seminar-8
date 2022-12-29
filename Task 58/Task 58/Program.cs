Console.WriteLine("Введите данные для первой матрицы");
Console.WriteLine();
int a = ReadLine("Количество строк: ");
int b = ReadLine("Количество столбцов: ");
Console.WriteLine();
Console.WriteLine("Введите данные для второй матрицы");
Console.WriteLine();
int c = ReadLine("Количество строк: ");
int d = ReadLine("Количество столбцов: ");
Console.WriteLine();


int[,] firstMatrix = new int[a, b];
int[,] secondMatrix = new int[c, d];


Console.WriteLine("Первая матрица");
Console.WriteLine();
FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
Console.WriteLine();
FillArray(secondMatrix);
PrintArray(secondMatrix);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
Console.WriteLine();
PrintArray(CompositionMatrix(firstMatrix, secondMatrix));


static int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
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