using System;
using System.Collections.Generic;
using System.Linq;


namespace CodeWars
{
    public class Tribonnaci
    {
        public void TribbonacciNumbers(double[] signature, int n)
        {
            var firstThreeNums = signature;
            var tribonnachiList = signature.ToList(); 
            var counter = 0;
            
            for(int i = 0; i <= n; i++)
            {
                firstThreeNums = tribonnachiList.GetRange(counter, 3).ToArray();
                tribonnachiList.Add(FindSum(firstThreeNums));
                counter++;
                if(counter >= n - 3)
                {
                    break;
                }
            }

            tribonnachiList =  tribonnachiList.GetRange(0,n);
            foreach (var digit in (tribonnachiList))
            {
                Console.Write($"{digit} ");
            }
        }
        private static double FindSum(double[] signature)
        {
            var tempArray = signature;
            double a, b, c, sum;
            a = double.Parse(tempArray[0].ToString());
            b = double.Parse(tempArray[1].ToString());
            c = double.Parse(tempArray[2].ToString());
            sum = a + b + c;
            return sum;
        }
    }
}
