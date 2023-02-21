// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void Polindrom(int num)
{
    int pos = num % 10;
    int pred = ((num%100) - pos) / 10;
    int per = num / 10000;
    int vtor = (num/1000) % 10;
    if ( pos == per && pred == vtor)
    {
        Console.WriteLine("Полиндром");
    }
    else 
    {
        Console.WriteLine("НЕ полиндром");
    }
}
Console.WriteLine("Ведите число :");
int n = Convert.ToInt32(Console.ReadLine());
Polindrom(n);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//  double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
//  {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2) ),2);
//  }
//   Console.WriteLine("Input xa:");
//   double xa = Convert.ToDouble(Console.ReadLine());
//   Console.WriteLine("Input ya:");
//   double ya = Convert.ToDouble(Console.ReadLine());
//   Console.WriteLine("Input za:");
//   double za = Convert.ToDouble(Console.ReadLine());
//   Console.WriteLine("Input xb:");
//   double xb = Convert.ToDouble(Console.ReadLine());
//   Console.WriteLine("Input yb:");
//   double yb = Convert.ToDouble(Console.ReadLine());
//   Console.WriteLine("Input zb:");
//   double zb = Convert.ToDouble(Console.ReadLine());
 //   Console.WriteLine($"Distance between our points - > {FindDistance(xa,ya,za,xb,yb,zb)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//  void FindQuard (int n)
//  {
//      int i = 1;
//      while (i<=n) 
//      {
//        Console.WriteLine($"Куб числа {i} - > {Math.Pow(i,3)}");
//        i++;
//      }
//  }
//   Console.WriteLine("Input N:");
//   int n = Convert.ToInt32(Console.ReadLine());
//   FindQuard(n);