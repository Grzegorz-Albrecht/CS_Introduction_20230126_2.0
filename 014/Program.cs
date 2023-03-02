// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
Console.Write("Введите a: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите a: ");
int b=Convert.ToInt32(Console.ReadLine());
int k=a%b;
if (k==0)
    Console.WriteLine("число a кратно числу b");
else 
    Console.WriteLine($"{k}"); 