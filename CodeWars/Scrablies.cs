using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Scrablies
    {
        public bool Scramble(string str1, string str2)
        {
            bool result = false;
            bool isContains = false;
            
            List<char> sortedString1;
            List<char> sortedString2;

            sortedString1 = str1.ToList();
            sortedString2 = str2.ToList();
            
            sortedString1.Sort();
            sortedString2.Sort();

            sortedString1.ForEach(delegate(char c) { Console.Write($"{c} "); });
            Console.WriteLine();
            sortedString2.ForEach(delegate(char c) { Console.Write($"{c} "); });

            if (sortedString1 == sortedString2) result = true;
            else
            {
                if (sortedString1.Count > sortedString2.Count)
                {
                    sortedString2.ForEach(delegate(char c) {
                        if (sortedString1.Contains(c))
                        {
                            isContains = true;
                        }
                        else
                        {
                            isContains = false;
                            return;
                        }
                    });
                    if (isContains)
                    {
                        
                        result = true;
                    }
                }
                else if(sortedString1.Count < sortedString2.Count)
                {
                    sortedString1.ForEach(delegate(char c) {
                        if (sortedString2.Contains(c))
                        {
                            isContains = true;
                        }
                        else
                        {
                            isContains = false;
                            return;
                        }
                    });
                    if (isContains)
                    {
                        result = true;
                    }
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
    }
}