// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;

double[,] Matrix = new double[m, n];

for (int i = 0; i < Matrix.GetLength(0); i++)
{
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        Matrix[i, j] = Random.Shared.NextDouble() * 10 - 5;
        
        Console.Write($"{Math.Round(Matrix[i, j], 1)} ");
    }
    Console.WriteLine();
}