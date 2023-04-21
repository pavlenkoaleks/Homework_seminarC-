// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
using System;
using static System.Console;
Clear();
Write("Введите размерность матриц: ");
int dimension=int.Parse(ReadLine());
int[,] array1 = GetArray(dimension, 0, 9);
int[,] array2 = GetArray(dimension, 0, 9);
WriteLine("Матрица 1: ");
PrintArray(array1);
WriteLine("Матрица 2: ");
PrintArray(array2);
int[,] product = MatrixProduct(array1,array2);
PrintArray(product);

int[,] GetArray(int d, int minValue, int maxValue)
{
int[,] result = new int[d, d];
for (int i = 0; i < d; i++)
{
for (int j = 0; j < d; j++)
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


int[,] MatrixProduct(int[,] array1, int[,] array2)
{
Write("Произведение матриц: ");
WriteLine();

int[,] result = new int[array1.GetLength(0),array1.GetLength(0)];
for (int i = 0; i < array1.GetLength(0); i++){
    for (int j = 0; j < array1.GetLength(0); j++){
      int sum = 0;
          for (int k = 0,l=0; k < array1.GetLength(0); k++,l++){ 
            sum=sum+array1[i,k]*array2[l,j];// правило умножения матриц
                  }
      result[i,j]=sum;
    }
    }
     return result;
}
