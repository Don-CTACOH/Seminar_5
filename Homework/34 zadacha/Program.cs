/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] CreateArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
    return array;
}
Console.Write("[");
void PrintArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        if (i < size - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]}]");
    }
}
int[] massiv = CreateArray();
PrintArray(massiv);
int i = 0;
int sum = 0;
while (i < massiv.Length)
{
    if (massiv[i] % 2 == 0)
        sum++;
    i++;
}
Console.Write($"Количество чётных чисел в массиве = {sum}");