/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76*/

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] CreateArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
Console.Write("[");
void PrintArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        if (i < size - 1)
            Console.Write($"{array[i]} ");
        else
            Console.WriteLine($"{array[i]}]");
    }
}
int[] massiv = CreateArray();
PrintArray(massiv);
int i = 0;
int max = massiv[i];
int min = massiv[i];
int raznica = 0;
while (i < massiv.Length)
{
    if (massiv[i] > max)
    {
        max = massiv[i];
    }
    else if (massiv[i] < min)
    {
        min = massiv[i];
    }
    i++;
}
raznica = max - min;
Console.Write($"Разница между максимальным и минимальным элементами массива = {raznica}");