using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimbirSoft_testCase
{
    class Parser
    {
        private List<string> parsedString = new List<string>();
        private readonly Regex regex = new Regex(@"[a-z]", RegexOptions.IgnoreCase);

        public Parser(string stringForParse)
        {
            Parse(stringForParse);
        }

        private List<string> Parse(string stringForParse)
        {
            string temp = "";
            for (int i = 0; i < stringForParse.Length; i++)
            {
                if (regex.IsMatch(Char.ToString(stringForParse[i]))) 
                {
                    temp += stringForParse[i];
                } 
                if ((!regex.IsMatch(char.ToString(stringForParse[i])) && temp.Length != 0) || (i == stringForParse.Length - 1 && temp.Length != 0))
                {
                    parsedString.Add(temp);
                    temp = "";
                }
            }
            return parsedString;
        }

        public List<string> GetList()
        {
            return parsedString;
        }
    }
}
