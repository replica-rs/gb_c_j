int firstvalue = Convert.ToInt32(Console.ReadLine());
int secondvalue = Convert.ToInt32(Console.ReadLine());
int thirdvalue = Convert.ToInt32(Console.ReadLine());
int maxvalue = 0;
if (firstvalue > secondvalue) 
{
    maxvalue = firstvalue;
}
else if (firstvalue < secondvalue) 
{
    maxvalue = secondvalue;
}
else 
{
    maxvalue = firstvalue;
}

if (thirdvalue > maxvalue) 
{
    maxvalue = thirdvalue;
}

    Console.Write("max: ");
    Console.WriteLine(maxvalue);