//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int N;
N = int.Parse(Console.ReadLine());
int A = N % 100 ;
int B = N %10 ;
int number = (A - B)/10;
Console.Write($"{number}");