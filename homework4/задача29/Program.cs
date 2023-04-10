// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
int[] array(int size){
    int[] result = new int[size];
    for(int i=0;i<size;i++){
        result[i]=new Random().Next(1,1000);
        
    }
return result;
}

Console.Clear();
Console.Write("Введите число : ");
int size = int.Parse(Console.ReadLine());
int[] array1 = array(size);

Console.WriteLine($"[   {String.Join(", ",array1)}   ]");
