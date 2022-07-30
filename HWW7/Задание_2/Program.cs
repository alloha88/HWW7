//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = 4;
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MinSum(int[,] newArray)
{
    int min = 0;
    int sum1 = int.MaxValue;
    int sum2 = 0;
    int row = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        sum2 = 0;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            sum2 = sum2 + newArray[i, j];
        }
        if (sum2 < sum1)
        {
            min = sum2;
            row = i;
        }
        sum1 = sum2;
    }
    Console.WriteLine("Минимальная сумма находится в " + row + " строке и равна -> " + min);
}
int[,] array = FillArray(rows, column);
printArray(array);
MinSum(array);