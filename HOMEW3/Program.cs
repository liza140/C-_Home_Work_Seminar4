// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 1. Проверка, является ли число отрицательным.
// 2. Определить количество цифр в числе.
// 3. Создать массив и заполнить его.
// 4. Найти сумму цифр числа (массива).

int NegNum(int N)
{
    if (N < 0) N = -N;
    return N;
}

int CountNum(int N)
{
    int count = 0;
    while (N > 0)
    {
        count++;
        N = N / 10;
    }
    return count;
}

int[] CreateAr(int N, int C)
{
    int[] arr = new int[C];
    for (int i = 0; i < C; i++)
    {
        arr[i] = N % 10;
        N = N / 10;
    }
    return arr;
}

string PrintArr(int[] arr)
{
    return String.Join(',', arr);
}

int SumArr(int[] arr)
{
    int S = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        S = S + arr[i];
    }
    return S;
}

int N = -65784;
N = NegNum(N);
int Con = CountNum(N);
int[] array = CreateAr(N, Con);
Console.WriteLine(PrintArr(array));
Console.WriteLine();
int Sum= SumArr(array);
Console.WriteLine(Sum);





