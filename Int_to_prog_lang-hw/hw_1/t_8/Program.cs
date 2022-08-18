int value = Convert.ToInt32(Console.ReadLine());
int vcount = 0;

 if (value > 0)
 {
   vcount = 2;

   while(vcount <= value)
   {
    Console.Write(vcount);
    Console.Write(" ");
    vcount = vcount + 2;
   }
 }
 else
 {
   vcount = -2;

   while(vcount >= value)
   {
    Console.Write(vcount);
    Console.Write(" ");
    vcount = vcount - 2;
   }
 }





