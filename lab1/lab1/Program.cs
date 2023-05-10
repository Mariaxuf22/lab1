using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2; 
            double b = 4; 

            double logab = Math.Log(b, a);
            double ln_a = Math.Log(a);
            double ln_b = Math.Log(b);

            double lhs = logab;
            double rhs = ln_a / ln_b;

            double epsilon = 0.000001; 
            bool areEqual = Math.Abs(lhs - rhs) < epsilon;

            Console.WriteLine($"log({a},{b}) = {logab}");
            Console.WriteLine($"ln({a}) / ln({b}) = {rhs}");
            Console.WriteLine($"Are they equal? {areEqual}");
            
        }
    }
}
