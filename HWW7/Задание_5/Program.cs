//  Заполните спирально массив 4 на 4.Например, на выходе получается вот такой массив

int rows = 4;
int columns = 4;

int[,] SpiralArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= result.GetLength(0) * result.GetLength(1))
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= result.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > result.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] / 10 <= 0) Console.Write($" {inArray[i, j]} ");
            else Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = SpiralArray(rows, columns);
PrintArray(matrix);
