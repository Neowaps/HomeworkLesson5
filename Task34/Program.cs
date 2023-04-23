// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами
// (длина массива 5 элементов). Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
int GetEven(int[] array)
{
    int result = 0;
    for (int i = 0, even; i < array.Length; i++)
    {
        even = array[i] % 2;
        if (even == 0)
        {
            result++;
        }
    }
    return result;
}

int[] newArray = new int[5];

FillArray(newArray);
System.Console.Write("Полученный массив: ");
PrintArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных чисел в массиве составляет: {GetEven(newArray)}");
