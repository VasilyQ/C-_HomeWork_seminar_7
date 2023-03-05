// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


int ReadNumber(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}



int[,] MatrixRandom(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(-10, 10);
            
            Console.Write($"{ matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

const int matrixLine = 3;
const int matrixColumn = 4;
int line = ReadNumber("Введите номер строки: ");
int column = ReadNumber("Введите номер столбца: ");
int [,] matrix = MatrixRandom(matrixLine, matrixColumn);

if( line > matrixLine || line < 0 || column > matrixColumn ||column < 0 )
{
    Console.WriteLine($"{line} {column} -> такого числа в массиве нет.");
}
else
{
    Console.WriteLine();
    Console.WriteLine(matrix[line, column]);
}