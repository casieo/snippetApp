using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetApp
{
    class Helper
    {
        public void AddSourceType(string SourceType)
        { }
        public void DeleteSourceType(string SourceType)
        { }

        static void AddSource(string SourceName)
        {
            Source SourceVariable = new Source();
            SourceVariable.SourceName = "TestSource";
            SourceVariable.SourceID = 1;
            Console.WriteLine("SourceName: {0}, SourceID: {1}",
                SourceVariable.SourceName, SourceVariable.SourceID);
        }

        public void AddComments(string Comments)
        { }
        public void DeleteComments(string Comments)
        { }

        public void AddAuthor(string AuthorName)
        { }
        public void DeleteAuthor(string AuthorName)
        { }
        public void AddSnippet(string SnippetText)
        { }
        public void DeleteSnippet(string SnippetText)
        { }
    }
}
