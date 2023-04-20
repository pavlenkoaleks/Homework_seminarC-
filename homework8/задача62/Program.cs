//  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
using System;
using static System.Console;
Clear();

Write("Введите число, с которого начать заполнение: ");
int firstnumber =int.Parse(ReadLine());
int[,] array = GetArray(4, firstnumber);
PrintArray(array);


int[,] GetArray(int m, int first)
{
int[,] result = new int[m, m];
result[0, 0]= first; 
result[0, 1]= first+1;
result[0, 2]= first+2;
result[0, 3]= first+3;
result[1, 0]= first+11;
result[1, 1]= first+12;
result[1, 2]= first+13;
result[1, 3]= first+4;
result[2, 0]= first+10;// если способ заполнения значения не имеет.
result[2, 1]= first+15;
result[2, 2]=first+14;
result[2, 3]= first+5;
result[3, 0]= first+9;
result[3, 1]= first+8;
result[3, 2]= first+7;
result[3, 3]= first+6;
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


