// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO)
Console.Write("Введите n: ");
int n=Convert.ToInt32(Console.ReadLine());
int d;
d=n/100%10;
if (n<100)
Console.WriteLine("NO");
else
Console.WriteLine($"{d}");