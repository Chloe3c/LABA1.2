//составить структурную схему алгоритма и проект программы вычисления функции, один параметр ввести с клавиатуры,
//а другой задать как константу, все вычисляемые значения вывести на экран.
//y = x**2 + sqrt3(|x|)
//x = cos**2 b + sin**2 a 
//a = sqrt(b + t**2)
//b = 8.1 , t = 2

try
{
    const double b = 8.1;
    const double t = 2;
    
    double a = Math.Sqrt(b + Math.Pow(t, 2)) ;
  
    double x = Math.Cos(b) * Math.Cos(b) + Math.Sin(a) * Math.Sin(a);
  
    double y = Math.Pow(x, 2) + Math.Pow(Math.Abs(x), 1 / 3);

    Console.WriteLine($"a = {a:F2}, x = {x:F2}, y = {y:F2}");
}

catch
{
    Console.WriteLine("Введите правильно!");
}
    