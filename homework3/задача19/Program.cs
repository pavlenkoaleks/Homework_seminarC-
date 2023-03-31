//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number;
number = int.Parse(Console.ReadLine());
if((number<100000&&number>9999)||(number>-100000&&number<-9999)){

int A = number/10000;
int B=(number%10000)/1000;
int D =(number%100)/10;
int E = number%10;
if((A==E)&&(B==D)) {Console.WriteLine("Это палиндром!");}
else{Console.WriteLine("Это не палиндром!");} }

else{Console.WriteLine("Неправильный ввод числа");}



