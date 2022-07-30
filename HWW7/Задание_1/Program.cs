// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = 3;
int column = 4;
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
            Console.Write($"{inArray[i, j]}| ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(1) - 1; k++)
            {
                if (newArray[i, k] > newArray[i, k + 1])
                {
                    int temp = newArray[i, k + 1];
                    newArray[i, k + 1] = newArray[i, k];
                    newArray[i, k] = temp;
                }
            }
        }
    }
}
int[,] array = FillArray(rows, column);
printArray(array);
SortArray(array);
Console.WriteLine();
printArray(array);