﻿// //Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuard (int x, int y)
{
  if (x>0 && y>0) return 1;
  if (x<0 && y>0) return 2;
  if (x<0 && y>0) return 3;
  if (x>0 && y<0) return 4;

  return 0;
}
 Console.WriteLine("Ввести x");
 int x = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Ввести y");
 int y = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine(FindQuard(x,y));
// _____
// int FindQuart (double x, double y)
// {
//     if(x>0 && y>0)
//     { 
//         return 1;
//     }
//     if(x<0 && y>0) return 2;
//     if(x<0 && y<0) return 3;
//     if(x>0 && y<0) return 4;

//     return 0;
// }
// Console.WriteLine("Input X:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y:");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindQuart(x,y));

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance (double xa, double ya, double xb, double yb)
// {
//    return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) ),2);
// }
//  Console.WriteLine("Input xa:");
//  double xa = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Input ya:");
//  double ya = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Input xb:");
//  double xb = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Input yb:");
//  double yb = Convert.ToDouble(Console.ReadLine());
 
//  Console.WriteLine($"Distance between our points - > {FindDistance(xa,ya,xb,yb)}");


//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

//  void FindQuard (int c)
//  {
//      if (c == 1) Console.WriteLine(" x>0 & y>0");
//      if (c == 2) Console.WriteLine(" x<0 & y>0");
//      if (c == 3) Console.WriteLine(" x<0 & y<0");
//      if (c == 4) Console.WriteLine(" x>0 & y<0");
//      else 
//      Console.WriteLine("Ошибочный ввод");
    
// }
// Console.WriteLine("Input c:");
// int c = Convert.ToInt32(Console.ReadLine());
// FindQuard(c);




//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// void FindQuard (int n)

// {
//     int i = 1;
//     while (i<=n) 
//     {
//       Console.WriteLine($"Квадрат числа {i} - > {i*i}");
//       i++;

//     }

// }
//  Console.WriteLine("Input N:");
//  int n = Convert.ToInt32(Console.ReadLine());
//  FindQuard(n);
