// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1. Создание и заполнение массива.
//2. Печать массива.

int[] CreateArr(int N)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(-10,10);
    }
    return arr;
}
string PrintArr (int[] arr)
{
    return String.Join(',', arr);
}

int Num = 8;
int[] array = CreateArr(Num);
Console.WriteLine(PrintArr(array));
