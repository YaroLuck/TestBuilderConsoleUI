using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBuilderConsoleUI.Model
{
    public class Document
    {
        public Zadanie zadanie { get; set; }
        public Dictionary<string, string> replacmentDictinary { get; set; }
        public string Path { get; set; }
        public string Stroka { get; set; }
    }
}
