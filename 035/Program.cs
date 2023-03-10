// 35.Подсчитать сумму цифр в числе. Сделать подпрограмму
Console.Write("Введите N: ");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(N));



int SumOfDigits(int N)
{
int sumOfDigits=0;
while(N>=1)
{
sumOfDigits+=N%10;
N=N/10;
}
return sumOfDigits;
}
