// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
int maxI = 0;
int minI = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"введите {i + 1}й элемент: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
for (int i = 1; i < size; i++)
{
    if (array[maxI] < array[i]) maxI = i;
    if (array[minI] > array[i]) minI = i;
}
Console.WriteLine($"Разница между максимальным: {array[maxI]} и минимальным элементом массива: {array[minI]} равна: {array[maxI] - array[minI]}");