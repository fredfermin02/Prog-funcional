using System;

namespace fibonacci
{
  class Program
  {
    public static void Main(string[] args)
    {
      Func<int> Addup = Suma(5);
      int a;
      Console.Write("Cuantas cifras desea mostrar");
      a = int.Parse(Console.ReadLine());

      for (int i =0; i<a; i++) {
        Console.WriteLine(Addup());
      }
    }
    private static Func<int> Suma(int k)
    {
      int a= 0;
      int b= 1;
      int c= 0;

      return()=>{
        c=b+a;
        b=a;
        a=c;
        return c;
      };
    }
  }
}
