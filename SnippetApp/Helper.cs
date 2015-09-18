using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetApp
{
    public static class Helper
    {
        static List<Source> sources = new List<Source>();

        public static Source AddSource(string SourceName)
        {
            Source SourceVariable = new Source(SourceName);
            sources.Add(SourceVariable);
            return SourceVariable;
        }
    
        public static void ShowSources()
        {
            foreach (var source in sources)
            {
               source.ShowSources = string.Format("New Source Added", source.SourceName); 

                //Console.WriteLine("New Source Added", source.SourceName); 
            }
        }
        public static void AddSourceType(string SourceType)
        { }
        public static void DeleteSourceType(string SourceType)
        { }
        public static void AddComments(string Comments)
        { }
        public static void DeleteComments(string Comments)
        { }

        public static void AddAuthor(string AuthorName)
        { }
        public static void DeleteAuthor(string AuthorName)
        { }
        public static void AddSnippet(string SnippetText)
        { }
        public static void DeleteSnippet(string SnippetText)
        { }
    }
}
