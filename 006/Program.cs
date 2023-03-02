// 6. Написать программу вычисления значения функции y = sin(a). 
Console.Write("Введите a: ");
double a=Convert.ToDouble(Console.ReadLine());
double y=Math.Sin(a);
Console.WriteLine($"sin({a})={y}");
