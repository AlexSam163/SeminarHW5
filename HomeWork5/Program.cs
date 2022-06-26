/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
 [345, 897, 568, 234] -> 2*/



int size = Input("Введите размер массива: ");
int[] array = new int [size];
int numbers=0;
FillArrayRandomNumbers(array);
PrintArray(array);

for (int i=0; i<array.Length; i++)
{
    if(array [i]%2==0)
    {
        numbers++;
    }
}

Console.WriteLine($"Количество чётных чисел в массиве: {numbers}");

void PrintArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/



int size = Input("Введите размер массива: ");
int[] array = new int [size];
int numbers=0;
FillArrayRandomNumbers(array);
PrintArray(array);

for (int i=1; i<array.Length; i+=2)
{
    numbers+=array[i];
}

Console.WriteLine($"Сумма элементов: {numbers}");

void PrintArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
 [3 7 22 2 78] -> 76 */

int size = Input("Введите размер массива: ");
int[] array = new int[size];
int i = 0;
FillArrayRandomNumbers(array);
PrintArray(array);


int minNumber(int[] arr)
{
    int minNumber = arr[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (arr[i] < minNumber)
        {
            minNumber = arr[i];
        }
    }
    return minNumber;
}

int maxNumber(int[] arr)
{
    int maxNumber = arr[0];
    for (int i = 1; i < array.Length; i++) 
    {
        if (arr[i] > maxNumber)
        {
            maxNumber = arr[i];
        }
    }
    return maxNumber;
}

Console.WriteLine(maxNumber(array) - minNumber(array));

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

