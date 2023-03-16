// Задача 93: Задайте две матрицы. Напишите программу с подпрограммой MultiMatrix, которая будет находить произведение двух матриц. 
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
System.Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите K: ");
int K = Convert.ToInt32(Console.ReadLine());
int[,] a=Random2DArray(N,K,0,10);
int[,] b=Random2DArray(N,K,0,10);
int[,] c=Random2DArray(N,K,0,10);
// int[,] a={{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4},{5, 2, 6, 7}};
// int[,] b={{1, 5, 8, 5},{4, 9, 4, 2},{7, 2, 2, 6},{2, 3, 4, 7}};
// int[,] c={{1, 5, 8, 5},{4, 9, 4, 2},{7, 2, 2, 6},{2, 3, 4, 7}};
System.Console.WriteLine("Массив a:");
Print2DArray(a);
System.Console.WriteLine("Массив b:");
Print2DArray(b);
System.Console.WriteLine("Массив с (произведение a и b):");
MultiMatrix(c);


int[,] Random2DArray(int N, int K,int min, int max)                      
{
    int[,] a=new int[N,K];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}

void MultiMatrix(int [,] c)
{
    for(int i=0;i<c.GetLength(0);i++)
    {
    for(int j=0;j<c.GetLength(1);j++)
    {
    c[i,j]=Convert.ToInt32(a[i,j]*b[i,j]);
        System.Console.Write($"{c[i,j],5}");
    }
    System.Console.WriteLine();
    }
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
