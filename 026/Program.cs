// 26.Программа проверяет пятизначное число на палиндромом. Например: 12321
Console.Write("Введите пятизначное число: ");
int a=Convert.ToInt32(Console.ReadLine());
int d1,d2,d4,d5;
d1=a%10;
d2=a/10%10;
d4=a/1000%10;
d5=a/10000%10;
if (d1==d5 & d2==d4)
Console.WriteLine("Число - палиндромом");
    else
Console.WriteLine("Число - не палиндромом");