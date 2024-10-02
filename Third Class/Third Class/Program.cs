using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Class
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            int[] tomb = TombGenerator(100);

            Console.WriteLine("--VÉGE--");
            Console.ReadKey();

        }
        private static int[] TombGenrator(int v)
        {
            int[] res = new int[v];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = rnd.Next(); 
            }
            return res;
        }
        /*
         
        
        static int osszead(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
        static double osszead(double a, double b)
        {
            Console.WriteLine(a + b);
            return a + b;
        } 
         
         */
    }
} // shutdown -i
