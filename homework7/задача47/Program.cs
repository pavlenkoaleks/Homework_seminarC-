
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

float[,] new_array(int rows,int columns){
    float[,] result = new float[rows,columns];
    for(int i=0;i<rows;i++){
          for(int j=0;j<columns;j++){
        result[i,j]=(new Random().Next(-10000,10000));

        result[i,j] = result[i,j]/100;
    }}
return result;
}

void PrintArray(float[,] array){

for(int i =0; i<array.GetLength(0);i++){
for(int j =0; j<array.GetLength(1);j++){
    Console.Write($"{array[i,j]}  ");

}
Console.WriteLine();
}

}

Console.Clear();
Console.Write("Введите количество строк : ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = int.Parse(Console.ReadLine());
float[,] array1 = new_array(rows,columns);
PrintArray(array1);


