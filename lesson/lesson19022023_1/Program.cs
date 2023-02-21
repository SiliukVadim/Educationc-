// // вид 1
// void Method1()
//     {
//         Console.WriteLine("Автор ...");
//     }
// Method1(); //вызов метода

// // вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");
// void Method21(string msg, int count)
// {
//         int i = 0;
//         while (i < count)
//         {
//             Console.WriteLine(msg);
//             i++;
//         }
// }
// // Method21("текст",4);
// Method21(count:4, msg: "новый текст");

// // Вид3 . Возвращает данные, но не принимает
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// // Вид4 Принимают и возвращают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// // Цикл FOR
//  string Method5(int count, string text)
//  {
     
//      string result = string.Empty;
//      for(int i = 0; i < count; i++)
//      {
//          result = result + text;
//      }
//      return result;
//  }
//  string res = Method5(10, "asdf");
//  Console.WriteLine(res);

// Цикл FOR в for
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

////=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             0123
// // s[3]//r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;                           //инициализация пустой строки

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();

// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }


        int temprary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);