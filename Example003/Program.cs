// Написать программу вычисления функции Аккермана

int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return AckermanFunction(n - 1, 1);
    if (n > 0 && m > 0) return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
    return AckermanFunction(n,m);
}
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Результат " + AckermanFunction(n,m));