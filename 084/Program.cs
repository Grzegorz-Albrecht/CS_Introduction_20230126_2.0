// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
//Вычислить сумму цифр введенного числа

Console.Write("Введите s: ");
string s=Console.ReadLine();
string k="";
int N=0;
bool t= true;
foreach(char c in s)
{
if (char.IsDigit(c)) k=k+c;
    else
    t=false;
}
if(t)
Console.WriteLine($"Сумма цифр равна: {SumOfDigits(N)}");
else
     System.Console.WriteLine("Введенное число не является правильной записью целого числа");


int SumOfDigits(int N)
{
int sumOfDigits=0;
N=Convert.ToInt32(k.ToString());
while(N>=1)
{
sumOfDigits+=N%10;
N=N/10;
}
return sumOfDigits;
}