// 98. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника
int row = 14;
int[,] triangle = new int[row, row];
// const int cellWidth = 3;
FillTriangle();
// PrintTriangle();
Print2DArray(triangle);



void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
        for (int j = 1; j <= i; j++)
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
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