// 7.Выяснить является ли число чётным.
int N2;
string s;
    System.Console.Write("Введите N2: ");
    s=Console.ReadLine();
    N2=Convert.ToInt32(s);
    bool odd= N2%2==0;
    if (odd==true)
    {
        System.Console.WriteLine($"Число {N2} четное ");
    }
    else  
    {
         System.Console.WriteLine($"Число {N2} не четное ");
    }