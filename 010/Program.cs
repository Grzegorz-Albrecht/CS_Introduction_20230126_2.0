// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
System.Console.Write("Введите n: ");
int n=Convert.ToInt32(Console.ReadLine());
int d;
d=n%10;
System.Console.WriteLine($"{d}");
