void A8V()
{
    int[] temp = new int[8];

    Random rng = new Random();

    System.Console.Write("[");

    for (int i = 0; i < 7; i++)
    {
        temp[i] = rng.Next(1,100);

        if (i != 6)
        {
            System.Console.Write($"{temp[i]},");
        }
        else
        {
            System.Console.Write(temp[i]);
        }
    }

    System.Console.WriteLine("]");

}

A8V();