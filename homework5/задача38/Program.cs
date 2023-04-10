// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

float[] new_array(int size){
    float[] result = new float[size];
    for(int i=0;i<size;i++){
        result[i]=(new Random().Next(-10000,10000));

        result[i] = result[i]/100;
    }
return result;
}

float diffMaxMin(float[] array){
float Max = array[0];
float Min = array[0];
for(int i =1; i<array.Length;i++){
    if (array[i]<Min) {Min = array[i];};
    if (array[i]>Max) {Max = array[i];};
}
float result = Max-Min;
return result;
}

Console.Clear();
Console.Write("Введите размерность массива : ");
int size = int.Parse(Console.ReadLine());
float[] array1 = new_array(size);
Console.WriteLine($"[{String.Join("; ",array1)}]");
Console.WriteLine($"разница между максимальным и минимальным элементами массива = {diffMaxMin(array1)}");

