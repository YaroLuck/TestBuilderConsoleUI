using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBuilderConsoleUI.Builders;
using TestBuilderConsoleUI.Interfaces;
using TestBuilderConsoleUI.Model;

namespace TestBuilderConsoleUI
{
    class Program
    {
        private static Zadanie zadanie = new Zadanie();
        static void Main(string[] args)
        {
            GetParametrForZadanie();
            IDocBuilder docBuilder;
            if(zadanie.Parametr == "1")
            {
                docBuilder = new SingleBuilder();
            }
            else if(zadanie.Parametr == "2")
            {
                docBuilder = new ComplexPSSBuilder();
            }
            else //(zadanie.Parametr == "3")
            {
                docBuilder = new ComplexNNBuilder();
            }
            //Document doc = docBuilder.CreateDocument();
            docBuilder.CreateDocument();
            docBuilder.GetZadanie(zadanie);
            string path = docBuilder.GetPathToShablon();
            Dictionary<string, string> replacementDictionary = docBuilder.FillReplaceDictionary();
            string stroka = docBuilder.CreateStrokaForCompess();
            Console.WriteLine(path);
            Console.WriteLine(stroka);
            Console.WriteLine(replacementDictionary.First());
            Console.ReadKey();
        }
        private static void GetParametrForZadanie()
        {
            zadanie.Parametr = Console.ReadLine().ToString();
        }
    }
}
