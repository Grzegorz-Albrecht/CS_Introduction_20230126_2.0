// 22. По двум заданным числам проверять является ли одно квадратом другого.
double a=12,b=144;
if (a*a==b)
Console.WriteLine("b является квадратом a");
else 
if (b*b==a)
Console.WriteLine("a является квадратом b");
else 
Console.WriteLine("не является квадратом");