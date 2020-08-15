using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeWars
{
    public class CountingDuplicates
    {
        public int Solve(string str)
        {
            char a;
            char b;
            int result = 0;
            str = str.ToLower();
            var duplicateList = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (i == j) break;
                    a = str[i];
                    b = str[j];
                    if (a == b)
                    {
                        if (!duplicateList.Contains(b)) duplicateList.Add(b);
                    }
                    
                }
            }
            
            result = duplicateList.Count;
            return result;
        }
        
    }
}