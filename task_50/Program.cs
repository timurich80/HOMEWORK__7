/* Задача 50. Напишите программу, которая на вход принимает индексы элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,1 -> 9
1,7 -> элемента с данными индексами в массиве нет */


int[,] array = new int[5,5];
System.Console.WriteLine("Введите индекс строки: ");
int coordinataY = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите индекс колонки: ");
int coordinataX = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrintArray(array);


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
if (coordinataX < array.GetLength(0) && coordinataY < array.GetLength(1)) Console.WriteLine(array[coordinataX, coordinataY]);
else Console.WriteLine($"{coordinataX} , {coordinataY} -> элемента с данными индексами в массиве нет ");