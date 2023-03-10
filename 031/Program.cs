// 31. Вывести на экран кубы чисел от 1 до N
// Console.Write("Введите N: ");
// int N=Convert.ToInt32(Console.ReadLine());
int N=10;
int k=1;
Console.WriteLine("Число"+"\t"+"Куб");
Console.WriteLine(Cube(k));



double Cube(int k)
{
    double cube=0;
    while (k<=N)
    {
        cube=Convert.ToDouble(Math.Pow(k,3));
        Console.WriteLine(k+"\t"+cube);
        k++;
    }
    return cube;
}
