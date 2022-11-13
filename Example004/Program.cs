// Написать программу возведения числа А в целую степень В
Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень ");
int B = int.Parse(Console.ReadLine());

int result = A;

for(int i = 1; i < B; i++){
    result = result * A;
}
Console.WriteLine(A + "^" + B + "=" + result);