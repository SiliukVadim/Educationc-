// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// Console.WriteLine("Vvedite X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Vvedite step");
// int step = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{x}^{step} = " + Math.Pow(x, step));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum (int num)
// {
//     int res = 0;
//     while (num > 0)
//     {
//         res += num %10;
//         num = num / 10;
//     }
//     return res;
// }
//  Console.WriteLine("Input num:");
//  int num = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine($"Сумма цифр числа {num} =  {Sum(num)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreatArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Input size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minValue:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxValue:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatArray(size, minValue, maxValue);
//ShowArray(CreateRandomArray(size, minValue, maxValue));
ShowArray(myArray);