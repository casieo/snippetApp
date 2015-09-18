using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.AddSource("test");
            Helper.ShowSources();
            //Console.WriteLine("Yay!");
            //Snippet InstantiatedSnippet = new Snippet();
            //Author InstantiatedAuthor = new Author();
            //Source InstantiatedSource = new Source();
            //SourceType InstantiatedSourceType = new SourceType();
            //Comments InstantiatedComments = new Comments();
        }
    }
}
