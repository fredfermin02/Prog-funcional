using System;

namespace contador
{
  class Program
  {
    public static void Main(string[] args)
    {
      Func<int> Addup = Suma(5);
      int a;
      Console.Write("Hasta que numero desea contar");
      a = int.Parse(Console.ReadLine());

      for (int i =0; i<a; i++) {
        Console.WriteLine(Addup());
      }
    }
    private static Func<int> Suma(int k)
    {
      int i =1;
      return () => i++;
    }
  }
}
