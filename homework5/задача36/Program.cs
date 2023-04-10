 //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] new_array(int size){
    int[] result = new int[size];
    for(int i=0;i<size;i++){
        result[i]=new Random().Next(-100,100);
        
    }
return result;
}

int sumNechet(int[] array){
   int result=0;
for(int i=0;i<array.Length;i+=2)
{
result+=array[i];

}
return result;
}

Console.Clear();
Console.Write("Введите размерность массива : ");
int size = int.Parse(Console.ReadLine());
int[] array1 = new_array(size);
int result= sumNechet(array1);
Console.WriteLine($"[{String.Join(", ",array1)}]");
Console.WriteLine($"сумма нечетных элементов = {result}");
