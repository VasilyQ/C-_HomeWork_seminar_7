// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] MatrixRandom(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 11);
            
            Console.Write($"{ matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}


double[] MatrixSum(int[,] matrix)
{
    double[] arrayResult = new double[matrix.GetLength(1)];
    double sum = 0;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
            count++;
        }
        sum /= count;
        arrayResult[i] = Math.Round(sum, 1);
        count = 0;
        sum = 0;
    }
    return arrayResult;
}



const int matrixLine = 3;
const int matrixColumn = 4;
int [,] matrix = MatrixRandom(matrixLine, matrixColumn);

double[] result = MatrixSum(matrix);

Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; " , result)}.");

// Console.WriteLine($"Среднее арифметическое каждого столбца:")