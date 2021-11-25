using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApp.Services
{
    public static class Algorithms
    {
        public static string IsPalindrom(string word)
        {
            int n = word.Length;
            for (int i = 0; i <  n/ 2; i++)
            {
                if(word[i] != word[n - i - 1]){
                    return "Слово - не палиндром!";
                }
            }
            return "Слово - палиндром!";
        }

        public static int CountSum(int[] someValues)
        {
            List<int> oddNum = new List<int>();
            for (int i = 0; i < someValues.Length; i++)
            {
                if (someValues[i] % 2 != 0)
                {
                    oddNum.Add(someValues[i]);
                }
            }
            int sum = 0;
            for (int i = 0; i < oddNum.Count; i++)
            {
                if ((i+1) % 2 == 0)
                {
                    sum += oddNum[i];
                }
            }
            return sum;
        }

        public static string LinkedSum(int number1, int number2)
        {
            LinkedList<int> num1 = new LinkedList<int>();
            LinkedList<int> num2 = new LinkedList<int>();

            LinkedList<int> num3 = new LinkedList<int>();

            while (number1 > 0)
            {
                num1.AddLast(number1 % 10);
                number1 /= 10;
            }
            while (number2 > 0)
            {
                num2.AddLast(number2 % 10);
                number2 /= 10;
            }

            int n = num1.Count > num2.Count ? num1.Count : num2.Count;
            int dec = 0;
            int currValue = 0;
            for (int i = 0; i < n; i++)
            {
                var val1 = i < num1.Count ? num1.ElementAt(i) : 0;
                var val2 = i < num2.Count ? num2.ElementAt(i) : 0;

                currValue = val1 + val2;

                num3.AddLast(currValue % 10 + dec);
                dec = currValue / 10;
            }
            if(dec != 0)
            {
                num3.AddLast(dec);
            }
            string result = "Сумма - ";
            for(int i = num3.Count-1; i >= 0; i--)
            {
                result += num3.ElementAt(i);
            }
            return result;
        }
    }
}
