// 30. Вывести на экран таблицу квадратов чисел от 1 до N
// Console.Write("Введите N: ");
// int N=Convert.ToInt32(Console.ReadLine());
int N=10;
int k=1;
Console.WriteLine("Число"+"\t"+"Квадрат");
Console.WriteLine(Square(k));



double Square(int k)
{
    double square=0;
    while (k<=N)
    {
        square=Convert.ToDouble(Math.Pow(k,2));
        Console.WriteLine(k+"\t"+square);
        k++;
    }
    return square;
}
