using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBuilderConsoleUI.Interfaces;
using TestBuilderConsoleUI.Model;

namespace TestBuilderConsoleUI.Builders
{
    public class SingleBuilder : IDocBuilder
    {
        public Document document { get; set; }
        public void CreateDocument()
        {
            document = new Document();
        }
        public string CreateStrokaForCompess()
        {
            string stroka =
                 "1" + document.zadanie.Parametr;
            return document.Stroka = stroka;
        }
        public Dictionary<string,string> FillReplaceDictionary()
        {
            Dictionary<string, string> replacementDictionary = new Dictionary<string, string>
            {
                ["#mn#"] = document.zadanie.Parametr
            };
            return document.replacmentDictinary = replacementDictionary;
        }
        public string GetPathToShablon()
        {
            return document.Path = "/Single";
        }
        public void GetZadanie(Zadanie zadanie)
        {
            document.zadanie = zadanie;
        }
    }
}
