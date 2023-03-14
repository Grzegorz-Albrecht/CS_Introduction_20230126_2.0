// 68. Написать программу, которая обменивает элементы первой строки и последней строки
System.Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите K: ");
int K = Convert.ToInt32(Console.ReadLine());
int[,] a=Random2DArray(N,K,0,10);
int[,] b=new int[N,K];
Array.Copy(a,b,a.Length);
System.Console.WriteLine("Массив a: ");
Print2DArray(a);
System.Console.WriteLine("Массив b(копия a): ");
Print2DArray1(b);
System.Console.WriteLine("Измененный массив a: ");
ChangeArray (a);

void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void ChangeArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
    {
        Swap(ref a[0,j], ref a[N-1-i,j]);
        System.Console.Write($"{a[i,j],5}");
    }
    System.Console.WriteLine();
    }
}

int[,] Random2DArray(int N, int K,int min, int max)                      
{
    int[,] a=new int[N,K];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],5}");
    System.Console.WriteLine();
    }
}

void Print2DArray1(int[,] b)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{b[i,j],5}");
    System.Console.WriteLine();
    }
}
