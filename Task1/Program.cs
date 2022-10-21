// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Insert massive size:");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
Console.WriteLine("massive:");
PrintArray(array);
int count = 0;

for (int k = 0; k < array.Length; k++)
    if (array[k] % 2 == 0)
        count++;

Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}