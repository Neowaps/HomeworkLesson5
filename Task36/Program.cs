// Задача 36: Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов).
// Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(); // В задаче нет указания диапазона выборки случайных чисел :(
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int GetNotEven(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

int[] newArray = new int[5];

FillArray(newArray);
System.Console.Write("Полученный массив: ");
PrintArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Cумма элементов, стоящих на нечётных индексах: {GetNotEven(newArray)}");
