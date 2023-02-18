// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//  int DeleteDecimal (int num)
//  {
//      int sot = num / 100;
//      int ed = num % 10;
//      return ((num-sot*100)-ed)/10;
//  }
// int number = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine(DeleteDecimal(number));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
 void DeleteDecimal (int num)
  {
      int sot = num / 100;
      if (sot<1) Console.WriteLine ("Нет третьего числа");
      else {
        int ch1 = num/1000;
        int ch = num - ch1*1000;
        if (ch<=999 && ch>0) 
         {
           int number = ch/100;
           Console.WriteLine ($"Третье число {number}");
         }
        else Console.WriteLine ($"Третье число 0");
      }
  }
      
  
 int num = Convert.ToInt32(Console.ReadLine());

DeleteDecimal(num);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void FindQuard (int x)
// {
//   if (x == 1) Console.WriteLine ("Это рабочий день если не праздник");
//   if (x == 2) Console.WriteLine ("Это рабочий день если не праздник");
//   if (x == 3) Console.WriteLine ("Это рабочий день если не праздник");
//   if (x == 4) Console.WriteLine ("Это рабочий день если не праздник");
//   if (x == 5) Console.WriteLine ("Это рабочий день если не праздник");
//   if (x == 6) Console.WriteLine ("Это выходной день если нет переноса");
//   if (x == 7) Console.WriteLine ("Это рабочий день");
// else
//   Console.WriteLine ("В неделе 7 дней, а вы ввели больше или меньше");
// }
//  Console.WriteLine("Ввести день недели");
//  int x = Convert.ToInt32(Console.ReadLine());
 
//  FindQuard(x);

