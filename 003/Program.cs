//3. С клавиатуры вводятся два числа a и b. Найти максимальное из них. 
int a,b;
string s;
System.Console.Write("Введите a: ");
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.Write("Введите b: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);
if (a>b)
    System.Console.WriteLine("a - максимальное");
else 
    System.Console.WriteLine("b - максимальное"); 