/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */


Console.Clear();
System.Console.WriteLine("Введите колличество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите колличество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[row, column];

FillArray(arr);
PrintArray(arr);

void FillArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }

    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Console.Write(String.Join(", ", array[i,j]));
            System.Console.Write($"{array[i,j]}  ");
        }
        System.Console.WriteLine();
    }
}