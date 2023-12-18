void www(int a)
{
  
  if(a > 0)
    {
        www(a - 1);
        Console.Write(a + " ");
    }
} 
int a = Convert.ToInt32(Console.ReadLine());
www(a);
