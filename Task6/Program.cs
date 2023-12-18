void www(int a, int b)
{  
    if( a < b )
    {
      if(a%2 == 0) Console.Write(a + " "); 
      www(a+1 ,b);
    }
}
void wow(int a, int b)
{  
    if( a < b )
    {
      if(a%2 != 0) Console.Write(a + " "); 
      wow(a+1 ,b);
    }
}
int a = Convert.ToInt32(System.Console.ReadLine());
int b = Convert.ToInt32(System.Console.ReadLine());

Console.WriteLine("All even numbers from " + a + " to " + b + " are");
www(a,b);
System.Console.WriteLine();

Console.WriteLine("All odd numbers from " + a + " to " + b + " are");
wow(a,b);