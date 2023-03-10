// 33.Возведите число А в натуральную степень B используя цикл
Console.Write("Введите A: ");
int A=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int B=Convert.ToInt32(Console.ReadLine());
double P=1;



for (int i=1; i<=B; i++)
{
 P=Math.Pow(A,i);
}
Console.WriteLine(P);
