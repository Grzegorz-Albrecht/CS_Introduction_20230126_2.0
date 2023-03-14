// 62.В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
//Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.
System.Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите K: ");
int K = Convert.ToInt32(Console.ReadLine());
int[,] a=Random2DArray(N,K,0,100);
int[,] b=new int[N,K];
Array.Copy(a,b,a.Length);
System.Console.WriteLine("Массив a: ");
Print2DArray(a);
System.Console.WriteLine("Массив b(копия a): ");
Print2DArray1(b);
System.Console.WriteLine("Измененный массив a: ");
ChangeArray (a);


void ChangeArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
    {
     if (a[i,j]%2==0)
    a[i,j]=-a[i,j];
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
