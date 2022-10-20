// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Random rand = new Random ();
int[] Array = new int[rand.Next(1,10)];
int CountEven=0;
for (int i = 0; i < Array.Length; i++) 
{
    Array[i] = rand.Next(100,1000);
    if (i != 0) 
    {
        Console.Write(", ");        
    }
    Console.Write($"{Array[i]}"); 
    if (Array[i] % 2 == 0)  CountEven++;
}
Console.Write($"\nКоличество чётных чисел: {CountEven}");