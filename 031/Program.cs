// 31. Вывести на экран кубы чисел от 1 до N
Console.Write("Введите N: ");
double N=Convert.ToInt32(Console.ReadLine());
double k;
Console.WriteLine("Число"+"\t"+"Куб");
for (k=1; k<=N; k++)
{
double cube=Cube(k);
Console.WriteLine(k+"\t"+cube);
}



double Cube(double k)
{
    return Math.Pow(k,3);
}
