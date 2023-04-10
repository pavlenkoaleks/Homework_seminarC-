// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int sum(int a){
    int result=0;
    for(int i=1;a!=0;i++){
        result=result+a%10;
        a=a/10;
    }
return result;
}

Console.Clear();
Console.Write("Введите число : ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine(sum(A));
