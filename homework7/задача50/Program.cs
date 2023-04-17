// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

FindElement(array);

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

void FindElement(int[,] array)
{Write("Введите номер строки: ");
int a=int.Parse(ReadLine());
Write("Введите номер столбца: ");
int b=int.Parse(ReadLine()); 

if((a>array.GetLength(0))||(b>array.GetLength(1))){Write("Такого элемента нет");}
else{a--;b--;
    Write($"{array[a,b]}");}
}
