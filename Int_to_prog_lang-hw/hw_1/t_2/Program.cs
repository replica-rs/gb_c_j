int firstvalue = Convert.ToInt32(Console.ReadLine());
int secondvalue = Convert.ToInt32(Console.ReadLine());

if (firstvalue > secondvalue) 
{
    Console.Write("max: ");
    Console.WriteLine(firstvalue);
}
else if (firstvalue < secondvalue) 
{
    Console.Write("max: ");
    Console.WriteLine(secondvalue);
}
else 
{
    Console.WriteLine("Числа равны.");
}