 //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.Clear();
Console.Write("Введите  число: ");
int N;
N = int.Parse(Console.ReadLine());
int A = N / 100 ;



if (A==0) {Console.Write("Третьей цифры нет");}
    else{ 
        while (N>999) {
       N= N/10;
    }}
int result = N%10;
Console.WriteLine(result);