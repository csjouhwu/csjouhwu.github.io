using System;

namespace wk0302
{
    class Program
    {
        static void Main(string[] args)
        {
          int 總數 = 0;
          for (int i = 1; i <= 10; i++)
            {
              if ( i == 5 )
              {

              }
              else
              {
                  總數 = 總數 + i;
              }
              //Console.WriteLine(i);
            }
          Console.WriteLine(總數);
        }
    }
}
