// 32. Найти сумму чисел от 1 до А
Console.Write("Введите A: ");
int A=Convert.ToInt32(Console.ReadLine());
int k=1;
System.Console.WriteLine(Sum(k));




int Sum(int k)
{
    int sum=0;
    for (k=1; k<=A; k++)
    {
        sum+=k;
    }
    return sum;
}