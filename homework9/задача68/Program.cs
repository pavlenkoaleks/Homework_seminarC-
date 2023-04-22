//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using System;
using static System.Console;
Clear();

Write("Введите число M: ");
int m =int.Parse(ReadLine());
Write("Введите число N: ");
int n =int.Parse(ReadLine());
Write("Функция Аккермана: ");
int akk;
Write(akk = Akkerman(m,n));

int Akkerman(int M, int N)
{
    if(M==0) {return (N+1);}
    else{if(N==0){return (Akkerman(M-1,1));}
    else return Akkerman(M - 1, Akkerman(M, N - 1));}
}
