//y=k1*x+b1
//y=k2*x+b2

//0=(k1-k2)*x+(b1-b2)
//...

//x=(b1-b2)/-(k1-k2)
//y=k2*x+b2


Console.WriteLine("y=k1*x+b1");
Console.WriteLine("y=k2*x+b2");

Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b1-b2)/((k1-k2)*-1);

double y = k2*x+b2;

Console.WriteLine($"X равен: {x}.");
Console.WriteLine($"Y равен: {y}.");