int[] array = {1,78, 2, 3, 5, 78, 6, 95, 4, 7, 78};

int n = array.Length;
int find = 78;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;                      // после выполнения заканчивает цикл
    }
    index++;
}
