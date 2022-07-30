//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows1 = 3;
int column1 = 3;
int rows2 = 3;
int column2 = 3;
int[,] FillArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}
void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int [,] MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for(int k = 0; k < secondMatrix.GetLength(0); k++)
            {
            resultMatrix [i,j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    } 
    return resultMatrix;
} 
int[,] matrix1 = FillArray(rows1, column1);
int[,] matrix2 = FillArray(rows2, column2);
printArray(matrix1);
Console.WriteLine("и");
printArray(matrix2);
Console.WriteLine();
MatrixProduct(matrix1, matrix2);
int[,] result = MatrixProduct(matrix1, matrix2);
printArray(result);