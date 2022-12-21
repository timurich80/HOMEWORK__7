/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] array = new int[5,2];

FillArray(array);
PrintArray(array);
CalculationAVG(array);

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]}  ");
        }
        System.Console.WriteLine();
    }
}

void CalculationAVG(int[,] arr)
{   double avg=0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            avg=avg + arr[i,j];
        }
        System.Console.Write($"{avg/arr.GetLength(0)}  ");
        
    }
}
