void www(int a)
{
  
  if(a > 0)
    {
        Console.Write(a + " ");
        www(a - 1);
    }
} 
int a = Convert.ToInt32(Console.ReadLine());
www(a);
