// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Average(array);

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

void Average(int[,] array)
{Write("Среднее арифметическое каждого столбца: ");
WriteLine();
for (int j = 0; j < array.GetLength(1); j++){
    float sum=0;
    for (int i = 0; i < array.GetLength(0); i++)
         { sum=sum+array[i,j];   }
     float avrg=sum/array.GetLength(0);
     Write($"{avrg}; ");
}

}

