// 56. Написать программу копирования массива
int[] a= {3, 2, 7, 1, 9,3,8, 7};
int[] b=new int[a.Length];
Array.Copy(a,b,a.Length);
System.Console.Write("Массив a: ");
PrintArray(a);
System.Console.WriteLine();
System.Console.Write("Массив b(копия a): ");
PrintArray1(b);
ReverseArray(a);
System.Console.WriteLine();
System.Console.Write("Массив a перевертыш: ");
PrintArray(a);

void PrintArray1(int[] b)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{b[i]} ");
}
void PrintArray(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i]} ");
}
void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void ReverseArray(int[] a)
{
    for(int i=0;i<a.Length/2;i++)
    {
        Swap(ref a[i],ref a[a.Length-i-1]);
    }

}