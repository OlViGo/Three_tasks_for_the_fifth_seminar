// Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Insert massive size  ");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
Console.WriteLine("massive: ");
PrintArray(array);
double min = int.Parse(Console.ReadLine());
double max = int.Parse(Console.ReadLine());

for (int k = 0; k < array.Length; k++)
{
    if (array[k] > max)
        {
            max = array[k];
        }
    if (array[k] < min)
        {
            min = array[k];
        }
}

Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}