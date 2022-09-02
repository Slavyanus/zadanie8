// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateMatrix1 (int row, int col, int min, int max) 
{
    int[,] matrix1 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix1;
} 
 
int[,] CreateMatrix2 (int row, int col, int min, int max) 
{
    int[,] matrix2 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix2.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix2;
} 
 
void PrintMatrix1(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}
 
void PrintMatrix2(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}
 
void DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int aRows = matrix1.Length[0]; int aCols = matrix1[1].Length;
    int bRows = matrix2.Length[0]; int bCols = matrix2[1].Length;
    if (aCols != bRows)    
    double[][] result = MatrixCreate(aRows, bCols);
    for (int i = 0; i < aRows; i++) 
        for (int j = 0; j < bCols; j++) 
        for (int k = 0; k < aCols; k++)
        result[i][j] += matrix1[i][k] * matrix2[k][j];
    return result;
}
 
int[,] array2D = CreateMatrix1(2, 2, 0, 9);
int[,] matrix = CreateMatrix2(2, 2, 0, 9);
PrintMatrix1(array2D);
Console.WriteLine();
PrintMatrix2(array2D);
DivMatrix();