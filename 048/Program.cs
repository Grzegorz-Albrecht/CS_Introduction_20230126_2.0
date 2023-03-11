// 48. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
//Создайте массив, который является произведением пар чисел в одномерном массиве a. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// а) вариант когда в массиве четное кол-во элементов
// б) * вариант когда в массиве и четное и не четное кол-во элементов
Console.Write("Введите N: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);

for(int i=0;i<a.Length;i++)
    Console.Write($"{a[i]} ");
Console.WriteLine();

int[] b=new int[N/2];

for(int i=0;i<b.Length;i++)
    b[i]=a[i]*a[N-1-i];
for(int i=0;i<b.Length;i++)
    Console.Write($"{b[i]} ");
Console.WriteLine();