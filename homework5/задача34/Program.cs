//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] new_array(){
    int[] result = new int[3];
    for(int i=0;i<3;i++){
        result[i]=new Random().Next(100,1000);
        
    }
return result;
}

int even_numbers(int[] array){
    int j=0;
foreach(int el in array){
j += el%2!=0 ? 0: 1;

}
return j;
}

Console.Clear();

int[] array1 = new_array();
int result= even_numbers(array1);
Console.WriteLine($"[{String.Join(", ",array1)}]");
Console.WriteLine($"количество четных в массиве = {result}");
