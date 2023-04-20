//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
ArrangeRows(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
int[,] result = new int[m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
result[i, j] = new Random().Next(minValue, maxValue + 1);
}
}
return result;
}

void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Write($"{inArray[i,j]} ");
}
WriteLine();
}
}


void ArrangeRows(int[,] array)
{
Write("упорядоченный массив: ");
WriteLine();
for (int i = 0; i < array.GetLength(0); i++){
    for (int k = 0; k < array.GetLength(1); k++){
    int max = array[i,k];
    int q=k;
    for (int j = k+1; j < array.GetLength(1); j++)
         { if (array[i,j]>max) {max=array[i,j]; q=j;}  }
     int a = array[i,q];
     array[i,q]=array[i,k];
     array[i,k] = a;


     
}
}

}
