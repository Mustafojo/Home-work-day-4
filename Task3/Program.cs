int www(int a)
{
  
  if(a == 1)
    {
        return 1;
    }
    else
    {
        return a + www(a - 1);
    }
} 
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (www(a));


