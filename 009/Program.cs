// 9. Вывести на экран четные числа от 1 до N
int N;
string s;
    System.Console.Write("Введите N: ");
    s=Console.ReadLine();
    N=Convert.ToInt32(s);
int i=2;
while(i<=N)
{
    System.Console.WriteLine(i);
    i=i+2;
}