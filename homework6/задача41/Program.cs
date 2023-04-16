// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] new_array(int M){
    int[] result = new int[M];
    for(int i=0;i<M;i++){
        Console.Write("Введите число : ");
         result[i]  = int.Parse(Console.ReadLine());
    }
return result;
}

int morethanzero(int[] array){
int x=0;
for(int i =0; i<array.Length;i++){

    if (array[i]>0) {x++;};
}

return x;
}

Console.Clear();
Console.Write("Введите количество чисел : ");
int M = int.Parse(Console.ReadLine());
int[] array = new_array(M);

Console.WriteLine($"количество чисел больше 0 = {morethanzero(array)}");

