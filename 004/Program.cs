//4. По заданному с клавиатуры номеру дня недели вывести его название
int N;
string s;
System.Console.Write("Введите номер дня: ");
s=Console.ReadLine();
N=Convert.ToInt32(s);
if (N==1)
    System.Console.Write("Понедельник");
if (N==2)
    System.Console.Write("Вторник");
if (N==3)
    System.Console.Write("Среда");
if (N==4)
    System.Console.Write("Четверг");
if (N==5)
    System.Console.Write("Пятница");
if (N==6)
    System.Console.Write("Суббота");
if (N==7)
    System.Console.Write("Воскресенье");