﻿// 8. Вывести на экран числа от -N до N
int N;
string s;
    System.Console.Write("Введите N: ");
    s=Console.ReadLine();
    N=Convert.ToInt32(s);
int i=-N;
while(i<=N)
{
    System.Console.WriteLine(i);
    i=i+1;
}