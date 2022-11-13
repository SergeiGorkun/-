// Написать программу, показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем


void ShowNumbers(int A, int B, int N){
    Console.WriteLine("Ответ");
    Console.WriteLine(A);
    Console.WriteLine(B);
    int Next;
    for(int i = 0; i < N - 2; i++) {
        Next = A + B;
        Console.WriteLine(Next);

        A = B;
        B = Next;
    }
}


Console.WriteLine("Введите первое число ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во чисел ");
int N = int.Parse(Console.ReadLine());

ShowNumbers(A,B,N);