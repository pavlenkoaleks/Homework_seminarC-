//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B .
int Pow(int a,int b){
    int result=a;
    for(int i=1;i!=b;i++){
        result=result*a;
    }
return result;
}

Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Pow(A,B));
