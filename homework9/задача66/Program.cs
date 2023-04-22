//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
using System;
using static System.Console;
Clear();

Write("Введите число M: ");
int m =int.Parse(ReadLine());
Write("Введите число N: ");
int n =int.Parse(ReadLine());
Write("Сумма натуральных чисел от M до N: ");
int i=m;
int sumMtoN=0;
Sum(m,n,i,sumMtoN);

void Sum(int M, int N,int i,int sum)
{
    if (i<=N){
       sum=sum+i;
      
        i++;
        Sum(M,N,i,sum);
    }
    else { Write($"{sum} ");}
}
