// 74.Найти сумму цифр числа
int Sum(int N)
{
if (N<10) return N;
else return N%10+Sum(N/10);
}
Console.Write("Введите N: ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр числа {N} равна {Sum(N)}");
