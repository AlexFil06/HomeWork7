// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }

}

void FindMatrixElement(int[,] matrix, int positionRows, int positionСolumns)
{
    Console.Write($"{positionRows},{positionСolumns} -> ");
    if (positionRows < matrix.GetLength(0) && positionСolumns < matrix.GetLength(1))
    {
        Console.Write(matrix[positionRows, positionСolumns]);
    }
    else Console.Write("такого элемента в массиве нет");
}

int[,] array2D = CreateMatrixRndInt(5, 6, 1, 10);
PrintMatrix(array2D);
Console.Write("Введите индекс строки -> ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца -> ");
int columns = Convert.ToInt32(Console.ReadLine());
FindMatrixElement(array2D, rows, columns);


