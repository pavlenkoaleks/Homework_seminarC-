//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int number1;
number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2;
number2 = int.Parse(Console.ReadLine());
int max;
if (number1>number2){
    max = number1;
    Console.WriteLine($"Большее число: max =  {max}");
}
else{
    if (number2>number1){ max = number2;
    Console.WriteLine($"Большее число: max =  {max}");
}
else{Console.WriteLine("Числа равны");}
}


