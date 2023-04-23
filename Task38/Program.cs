// Задача 38: Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов).
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

double GetDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    diff = max - min;
    return diff;
}

double[] newArray = new double[5];

FillArray(newArray);
System.Console.Write("Полученный массив: ");
PrintArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {GetDiff(newArray)}");
