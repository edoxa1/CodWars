using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            //var countingDuplicates = new CountingDuplicates();
            //Console.WriteLine(countingDuplicates.Solve("aaabbbbc"));
            
            var scrablies = new Scrablies();
            Console.WriteLine(scrablies.Scramble("scriptsjava", "javascripts"));
        }
    }
}