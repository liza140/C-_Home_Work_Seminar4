//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. 

// 1. Проверка на натуроальность.
// 2. Возведение в степень.

double AbsB(double b)
{
    if (b < 0) b = -b;
    return b;
}

double StA(double a, double b)
{
    double c = Math.Pow(a, b);
    return c;
}

double A = 2;
double B = -3;
B = AbsB(B);
double C = StA(A, B);
Console.WriteLine(C);
