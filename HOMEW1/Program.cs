// Найти сумму чисел от 1 до А

// Создание массива и заполнение массива
// Набор массива для печати 
// Расчет суммы элементов массива

int[] CreateArray(int N)
{
    int[] arr = new int[N + 1];
    for (int i = 0; i <= N; i++)
    {
        arr[i] = i;
    }
    return arr;
}
string PrintArr(int[] arr)
{
    return String.Join(',', arr);
}
int SumArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int A = 7;
int[] array = CreateArray(A);
Console.WriteLine(PrintArr(array));
int S = SumArray(array);
Console.WriteLine();
Console.WriteLine(S);

