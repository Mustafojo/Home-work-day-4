void www(int a)

{
   int ch = 0;
   
       for (int i = a;i>0;i/=10)
    {
       ch = ch*10 + i%10;
        
    }
      for (int i = a;i>0;i/=10)
    {
        Console.Write(ch % 10 + " ") ;
          ch/=10;
    }
  
}
int a = Convert.ToInt32(Console.ReadLine());
www(a);
