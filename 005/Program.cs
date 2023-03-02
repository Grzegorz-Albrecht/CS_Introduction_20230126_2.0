// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a,b,c;
string s;
Console.Write("Введите a: ");
s=Console.ReadLine();
a=Convert.ToInt32(s);
Console.Write("Введите b: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);
Console.Write("Введите c: ");
s=Console.ReadLine();
c=Convert.ToInt32(s);
int Max=a;
if (b>Max)
Max=b;
if (c>Max)
Max=c;
    Console.Write("Max= ");
    Console.WriteLine(Max);