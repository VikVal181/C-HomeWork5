// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Random rand = new Random ();
double[] Array = new double[rand.Next(1,10)];

for (int i = 0; i < Array.Length; i++) 
{
    Array[i] = Math.Round(rand.Next(-99,100)*rand.NextDouble (),2);
    if (i != 0) 
    {
        Console.Write(" ");        
    }
    Console.Write($"{Array[i]}");

}

double ArrayMin = Array[0];
double ArrayMax = Array[0];
for (int i = 0; i < Array.Length; i++)
{ 
    if (Array[i]<ArrayMin) ArrayMin=Array[i];
    if (Array[i]>ArrayMax) ArrayMax=Array[i];
}   
Console.Write($"\nРазница между максимальным и минимальным элементом: {ArrayMax-ArrayMin}");