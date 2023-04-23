// Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int GetCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count++;
        }
    }
    return count;
}

int[] newArray = new int[10];

FillArray(newArray);
System.Console.Write("Полученный массив: ");
PrintArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] составляет: {GetCount(newArray)}");
