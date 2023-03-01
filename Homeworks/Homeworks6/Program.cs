// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void Chet(int[] array)
// {
//     int colchet = 0;
//     for(int i = 0;i < array.Length;i++)
//     {
//         if(array[i] % 2 == 0) colchet += 1;
//     }
//     Console.WriteLine($"Количество четных чисел -> {colchet}");
// } 
// Console.WriteLine("Ввести размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Минимальное значение");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Максимальное значение");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Chet(myArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void SumChet(int[] array)
// {
//     int sum = 0;
//     for(int i = 0;i < array.Length;i++)
//     {
//         if(i % 2 == 0) sum = sum;
//         else sum = array[i] + sum;
//     }
//     Console.WriteLine($"Сумма чисел на не чётных позициях -> {sum}");
// } 
// Console.WriteLine("Ввести размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Минимальное значение");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Максимальное значение");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// SumChet(myArray);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
//////Целые числа
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void Raz(int[] array)
// {
//     int min = array[0];
//     int max = 0;
//     for(int i = 0;i < array.Length;i++)
//     {
//         if(array[i] > max) max = array[i];
//         if(array[i] < min) min = array[i];
//     }
//     Console.WriteLine($"Разница между {min} и {max} {max - min}");
// } 
// Console.WriteLine("Ввести размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Минимальное значение");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Максимальное значение");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Raz(myArray);

////// ВЕЩЕСТВЕННЫЕ ЧИСЛА

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0;i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble());
    }
    return array;
}
void ShowArray (double[] array)
{
    for(int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void Raz(double[] array)
{
    double min = array[0];
    double max = 0;
    for(int i = 0;i < array.Length;i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между {min} и {max} {max - min}");
} 
Console.WriteLine("Ввести размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);
Raz(myArray);