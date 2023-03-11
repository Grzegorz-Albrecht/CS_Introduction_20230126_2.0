// 51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
System.Console.Write("Введите N: ");
int N=int.Parse(Console.ReadLine());
int[] a=new int[N];

for(int i=0;i<a.Length;i++)

    a[i]=int.Parse(Console.ReadLine());

for(int i=0;i<a.Length;i++)
    Console.Write($"{a[i]} ");
Console.WriteLine();
int j=0;
for(int i=0;i<a.Length;i++)
if (a[i]>0)
j++;
Console.Write($"Колиечство положительных чисел: {j}" );