// 30. Вывести на экран таблицу квадратов чисел от 1 до N
// Console.Write("Введите N: ");
// int N=Convert.ToInt32(Console.ReadLine());
// int k=1;
// Console.WriteLine("Число"+"\t"+"Квадрат");
// do
// {
//     Console.WriteLine(k+"\t"+Math.Pow(k,2));
//     k++;
// }
// while (k<=N);
Console.Write("Введите N: ");
double N=Convert.ToInt32(Console.ReadLine());
double k;
Console.WriteLine("Число"+"\t"+"Квадрат");
for (k=1; k<=N; k++)
{
double square=Square(k);
Console.WriteLine(k+"\t"+square);
}

double Square(double k)

{
    return Math.Pow(k,2);
}
