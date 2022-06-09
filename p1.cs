using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {   

        static int TriboRecursivo(int n)
        {
            if (n == 0 ) return 0;
            if (n == 1 ) return 0;
            if (n == 2 ) return 1;
                return TriboRecursivo(n - 1) + TriboRecursivo(n - 2) +TriboRecursivo(n - 3);
        }


        static int TriboNormal(int n)
        {
            int a = -1, b = 1, c = 0, d = 0;
            for (int i = 1; i < n; i++)
            {
                a = b;
                b = c;
                c = d;
                d = a + b + c;
            }
            return d;
        }
        

        static void printTribRec(int n)
        {
            for (int i = 1; i <=n; i++)
                Console.Write(TriboRecursivo(i)+ ", ");
        }



        static void printTribNorm(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.Write(TriboRecursivo(i) + ", ");
        }



        static void Main(string[] args)
        {
            int n;
            System.Console.WriteLine("====Tribonacci Estructurado====");
            System.Console.WriteLine("Introduce un numero n: ");
            n = Convert.ToInt32(System.Console.ReadLine());
            printTribNorm(n);

            System.Console.WriteLine();
            System.Console.WriteLine();
            
            System.Console.WriteLine("====Tribonacci Recursivo====");
            System.Console.WriteLine("Introduce un numero n: ");
            n = Convert.ToInt32(System.Console.ReadLine());
            printTribRec(n);
            System.Console.ReadKey();        
        }
    }
}
