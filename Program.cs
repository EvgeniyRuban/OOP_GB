﻿using System;
using System.Text;

namespace OOP_GB
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadKey();
        }

        public static string Reverse(string word)
        {
            StringBuilder result = new StringBuilder(word.Length);
            for(int i = word.Length - 1; i >= 0; i--)
            {
                result.Append(word[i]);
            }

            return result.ToString();
        }

        public static void SearchMail(ref string s)
        {
            char mailSymbol = '@';
            char splitter = ' ';
            StringBuilder temp = new StringBuilder(s.Length);
            string[] content = s.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

            s = s.Remove(0);
            foreach(string item in content)
            {
                if(item.Contains(mailSymbol))
                {
                    temp.AppendLine(item);
                }
            }
            s = temp.ToString();
        }
    }
}
