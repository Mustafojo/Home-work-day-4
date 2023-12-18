void www(int a)

{
   int ch = 0;
   
       for (int i = a;i>0;i/=10)
    {
        ch++;
    }

   Console.WriteLine(ch);
  
}
int a = Convert.ToInt32(Console.ReadLine());
 www(a);

