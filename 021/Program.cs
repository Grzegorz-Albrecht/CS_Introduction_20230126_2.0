// 21. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a=5467;
if (a==6 ^ a==7)
Console.WriteLine($"{a} - выходной");
else
    if (a>=1 & a<=5)
Console.WriteLine($"{a} - будний день");
else
System.Console.WriteLine("Это не день недели");