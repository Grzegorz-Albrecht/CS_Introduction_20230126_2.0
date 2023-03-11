//50. Выяснить являются ли три числа сторонами треугольника
Console.WriteLine("Введите 3 числа: ");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());

if (a+b>c && b+c>a && a+c>b) 
         System.Console.WriteLine("Являются"); 
    else System.Console.WriteLine("Не являются");