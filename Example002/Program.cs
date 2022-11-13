// Найти сумму элементов от M до N, N и M заданы

int M = 1;
int N = 12;

int Sum = 0;

while(M <= N){
    Sum = Sum + M;
    M++;
}

Console.WriteLine(Sum);
