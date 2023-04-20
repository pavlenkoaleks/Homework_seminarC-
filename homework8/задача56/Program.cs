//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;
using static System.Console;
Clear();
Write("Введите размерность массива: ");
int dimension =int.Parse(ReadLine());

int[,] array = GetArray(dimension, 0, 9);
PrintArray(array);
MinSumRows(array);


int[,] GetArray(int m, int minValue, int maxValue)
{
int[,] result = new int[m, m];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < m; j++)
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


void MinSumRows(int[,] array)
{
WriteLine("Cуммы строк: ");
int[] sums = new int[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++){
    int sum =0;
    for (int j= 0; j < array.GetLength(1); j++){
        sum=sum+array[i,j];
    } Write($"{sum} "); 
    sums[i]=sum;
    }
WriteLine();
WriteLine("Наименьшая сумма строк: ");
int min = sums[0];
for (int i = 1; i < sums.Length; i++){
    if (sums[i]<min) {min = sums[i];}
}
Write(min);
}