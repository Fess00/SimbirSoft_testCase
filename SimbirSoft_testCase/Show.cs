using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft_testCase
{
    class Show
    {
        private Parser parser;
        private Dictionary<string, int> dictToShow = new Dictionary<string, int>();

        public Show(string strToShow)
        {
            parser = new Parser(strToShow);
        }

        public void ShowItems()
        {
            for (int i = 0; i < parser.GetList().Count; i++)
            {
                if (dictToShow.ContainsKey(parser.GetList()[i]))
                {
                    dictToShow[parser.GetList()[i]] += 1;
                }
                else
                {
                    dictToShow[parser.GetList()[i]] = 1;
                }
            }

            foreach (var item in dictToShow)
            {
                Console.WriteLine($"{item.Key} " + ": " + $"{item.Value}");
            }
        }
    }
}
