using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            long i;
            long j;

            for (i = 3; i > 0 ; i += 2)
            {
                bool isPrime = true;

                for (j = 2; (j*j) < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);

                    using (System.IO.StreamWriter StreamWriter = System.IO.File.AppendText(@"C:\Users\Cyberadmin\Desktop\Prime number\Prime List.txt"))
                    {
                        StreamWriter.WriteLine(i);
                    }
                }
                
            }
        }
    }
}
