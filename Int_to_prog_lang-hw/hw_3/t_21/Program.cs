int[] fpoint = new int[3];
int[] spoint = new int[3];
double distance = 0;

int[] ReadСoord()
{
  int[] temp = new int[3];

    System.Console.Write($"Введите X:");
    temp[0] = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Введите Y:");
    temp[1] = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Введите Z:");
    temp[2] = Convert.ToInt32(Console.ReadLine());

     return temp;
}



System.Console.WriteLine("1-я точка.");
fpoint = ReadСoord();
System.Console.WriteLine("2-я точка.");
spoint = ReadСoord();

distance = Math.Sqrt(Math.Pow((spoint[0]-fpoint[0]),2)+Math.Pow((spoint[1]-fpoint[1]),2)+Math.Pow((spoint[2]-fpoint[2]),2));


static void WriteСoord(int[] value)
{
  System.Console.Write($"{value[0]}, ");
  System.Console.Write($"{value[1]}, ");
  System.Console.Write($"{value[2]}.");
}

System.Console.Write("Расстояние между точками: X(");
WriteСoord(fpoint);
System.Console.Write("), Y(");;
WriteСoord(spoint);
System.Console.WriteLine($") равно {Math.Round(distance,2)}.");
