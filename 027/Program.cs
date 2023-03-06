// 27. Найти расстояние между точками в пространстве 2D
Console.WriteLine("Введите координаты");
double x1=Convert.ToDouble(Console.ReadLine());
double x2=Convert.ToDouble(Console.ReadLine());
double y1=Convert.ToDouble(Console.ReadLine());
double y2=Convert.ToDouble(Console.ReadLine());
double n = Convert.ToDouble(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2));
double S=Convert.ToDouble(Math.Sqrt(n)); //расстояние 
Console.Write($"расстояние между точками {S}"); 