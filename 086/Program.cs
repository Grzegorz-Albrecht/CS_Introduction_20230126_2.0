// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
System.Console.Write("Введите s: ");
string s=Console.ReadLine();
int k=0;
foreach(char c in s)
if (c=='a') k++;
System.Console.WriteLine($"'a' встречается в строке {s} {k} раз");
