// Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9].
// Напишите программу получает на вход число и определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

bool GetCheck(int[] array, int number)
{
    bool check = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            check = true;
        }
    }
    return check;
}

int[] newArray = new int[8];

System.Console.Write("Введите число: ");
int numberCheck = int.Parse(Console.ReadLine());

FillArray(newArray);
System.Console.Write("Сгенерированный массив: ");
PrintArray(newArray);
System.Console.WriteLine();

System.Console.WriteLine(GetCheck(newArray, numberCheck) ? $"Заданное число ({numberCheck}) присутствует в массиве" : $"Заданное число ({numberCheck}) отсутствует в массиве");
