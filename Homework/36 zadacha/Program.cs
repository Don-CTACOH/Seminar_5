/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] CreateArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
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
    if (i % 2 != 0)
        sum = sum + massiv[i];
    i++;
}
Console.Write($"Сумма элементов с нечетным индексом = {sum}");