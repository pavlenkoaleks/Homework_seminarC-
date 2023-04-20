//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());
Write("Введите высоту массива: ");
int hight=int.Parse(ReadLine());
int[, ,] array = GetArray(rows, columns,hight, 10, 99);
PrintArray(array);


int[, ,]  GetArray(int m, int n,int h, int minValue, int maxValue)
{
int help =m*n*h;
int[] helper = new int[help]; // вспомогательный массив для проверки на повторяемость
int x=0;
int[, ,] result = new int[m, n, h];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
for (int k = 0; k < h; k++)
{
int s=0;
int rand =0;
while(s!=x){s=0; //  проверка на повторяемость
 rand = new Random().Next(minValue, maxValue + 1);
for(int zx = 0; zx<x ; zx++){
if (rand!=helper[zx]){s++;}
}
}
result[i,j,k] = rand;
helper[x]=result[i,j,k];x++;

}

}
}
return result;
}

void PrintArray(int[, ,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
for (int k = 0; k < inArray.GetLength(2); k++)
{
Write($"{inArray[i,j,k]}({i},{j},{k}) ");
}
}
WriteLine();
}

}



