// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int[] InputArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Prompt($"ВВедите {i+1}-ый элемент");
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }
// int CountPositiveNumbers (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// int lenght = Prompt("Введите количеств элементов >");
// int[] array;
// array = InputArray(lenght);
// PrintArray(array);
// Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int koef = 0;
const int constant = 1;
const int x_cord = 0;
const int y_cord = 1; 
const int line1 = 1;
const int line2 = 2;

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($" Точка пересечения уравнений y={lineData1[koef]}*x+{lineData1[constant]} и y={lineData2[koef]}*x+{lineData2[constant]}");
    Console.WriteLine($" имеет кооринаты ({coord[x_cord]}, {coord[y_cord]})");
}
double Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
double[] InputLineData(int numberOfline)
{
    double[] lineData = new double[2];
    lineData[koef] = Prompt($"Введите коэффициент для {numberOfline} прямой >");
    lineData[constant] = Prompt($"Введите коэффициент для {numberOfline} прямой >");
    return lineData;
}
double[] FindCoords (double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x_cord] = (lineData1[constant] - lineData2[constant]) / (lineData1[koef] - lineData2[koef]);
    coord[y_cord] = lineData1[constant] * coord[x_cord] + lineData1[constant];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[koef] == lineData2[koef])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
    return true;
}
