//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
// Console.WriteLine("Vvedite sravnivaemie chisla");
// Console.WriteLine("Input number1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number2");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2){
//     Console.WriteLine($"max = {num1} min = {num2}"); // в текстовом условии написанно, что нужно выводить и минимальное число
//  }
//  else{
//     Console.WriteLine($"max = {num2} min = {num1}");
//  }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
// Console.WriteLine("Vvedite kolichestvo chisel");
// int kol = Convert.ToInt32(Console.ReadLine());
// int n = 1;
// int max = 0;
// while(n <= kol)
//  {
//      Console.Write($" num{n} = ");
//      int num = Convert.ToInt32(Console.ReadLine());
//      if (max > num){
//         max = max;
//      }
//      else{
//         max=num;
//      }
//      n ++;
//  }
//  Console.WriteLine($"max = {max}");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Console.WriteLine("Vvedite chislo");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%2 == 0){
//     Console.WriteLine($"{num} - да чётное");
// }
// else{
//     Console.WriteLine($"{num} - нет не чётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Vvedite chislo N");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i<=n){
    if (i%2 == 0){
    Console.Write($"{i},");
    i++;
    }
    else{
        i++;
    }
}