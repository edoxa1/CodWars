using System;
using System.Linq;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Tribonnaci tribonacci = new Tribonnaci();
            tribonacci.TribbonacciNumbers(new double[]{1,1,1}, 10);
            
            var countingDuplicates = new CountingDuplicates();
            Console.WriteLine(countingDuplicates.Solve("aaabbbbc"));
            
            var scrablies = new Scrablies();
            Console.WriteLine(scrablies.Scramble("scriptsjava", "javascripts"));
        }
    }
}