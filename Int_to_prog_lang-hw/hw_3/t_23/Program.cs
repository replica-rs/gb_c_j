

double[] TofC(int value)
{
    int count = 0;
    double[] temp = new double[value];

    do 
     {
      temp[count] = Convert.ToDouble(Math.Pow(Convert.ToDouble(count+1),3));
      count = count + 1;
     }
    while(count < value);

 return temp;

}

static void WriteT(double[] value)
{
 for (int i = 0; i < value.Length; i++)
 {
    if (i < value.Length-1)
    {
       System.Console.Write($"{value[i]}, ");
    }
    else
    {
       System.Console.Write($"{value[i]}.");
    }
 }
}


System.Console.Write("Введите число: ");
 int value = Convert.ToInt32(Console.ReadLine());

double[] ntable = new double [value];
ntable = TofC(value);
WriteT(ntable);
