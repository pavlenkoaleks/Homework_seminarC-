//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
float[] intersection(float k1,float k2,float b1,float b2){
    float[] result = new float[2];
    result[0]=(b2-b1)/(k1-k2);
    result[1]=(k1*(b2-b1))/(k1-k2)+b1;
    return result;}
   




Console.Clear();
Console.Write("Введите k1 : ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("Введите k2 : ");
float k2 = float.Parse(Console.ReadLine());
Console.Write("Введите b1 : ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("Введите b2 : ");
float b2 = float.Parse(Console.ReadLine());
float[] array1 = new float[2];
if ((k1==k2)&&(b1==b2)){Console.Write("прямые совпадают ");} 
        else {if(k1==k2){Console.Write("прямые параллельны ");}
            else { array1 =  intersection(k1,k2,b1,b2);}
        }

Console.WriteLine($"[{String.Join("; ", array1)}]");
