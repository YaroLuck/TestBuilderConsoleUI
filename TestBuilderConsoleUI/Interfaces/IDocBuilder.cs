using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBuilderConsoleUI.Model;

namespace TestBuilderConsoleUI.Interfaces
{
    public interface IDocBuilder
    {
        Document document { get; set; }
        void CreateDocument();
        void GetZadanie(Zadanie zadanie);
        string GetPathToShablon();
        Dictionary <string,string> FillReplaceDictionary(); 
        string CreateStrokaForCompess(); 
    }
}
