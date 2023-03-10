// 36.Написать программу вычисления произведения чисел от 1 до N (факториал N)
Console.Write("Введите N: ");
int N=Convert.ToInt32(Console.ReadLine());
int k=1;
System.Console.WriteLine(Product(k));




int Product(int k)
{
    int product=1;
    for (k=1; k<=N; k++)
    {
        product*=k;
    }
    return product;
}