// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Random rand = new Random ();
int[] Array = new int[rand.Next(1,10)];
int CountOddPos=0;
for (int i = 0; i < Array.Length; i++) 
{
    Array[i] = rand.Next(-99,100);
    if (i != 0) 
    {
        Console.Write(", ");        
    }
    Console.Write($"{Array[i]}");
    if (i % 2 != 0) CountOddPos = CountOddPos + Array[i];
}
Console.Write($"\nСумма чисел на нечётных позициях: {CountOddPos}");