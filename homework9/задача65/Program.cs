// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
using System;
using static System.Console;
Clear();

Write("Введите число: ");
int number =int.Parse(ReadLine());

PrintNumb(number,number);

void PrintNumb(int number, int i)
{
    if (i>=1){
        Write(i + ", ");
        i--;
        PrintNumb(number,i);
    }


}
