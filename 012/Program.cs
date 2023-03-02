// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
Console.Write(" Введите n: ");
int n=Convert.ToInt32(Console.ReadLine());
int d0,d1;
d0=n%10;
d1=n/10;
if (d0>d1)
    Console.WriteLine($"{d0} - наибольшая цифра");
else
    Console.WriteLine($"{d1} - наибольшая цифра");