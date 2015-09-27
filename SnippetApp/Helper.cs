using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetApp
{
    public static class Helper
    {
        public static void CreateKb(string text, string pageOrLocation,  string sourceName, string sourceTypeName, string comment = "Default comment" )
        {
            using (var db = new SnippetAppCodeFirstDB())
            {
                Snippet sp = new Snippet();
                sp.Text = text;

                if (comment != "Default comment")
                {

                }

                db.Snippets.Add(sp);

                db.SaveChanges();
            }
        }

        public static Source AddSource(string SourceName)
        {
            using (var db = new SnippetAppCodeFirstDB())
            {
                Source source = new Source(SourceName);
                //source.SourceID = SourceId;
                //sources.Add(source);
                db.Sources.Add(source);
                db.SaveChanges();
                return source;
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
        #region old code
        //old list code
        // static List<Source> sources = new List<Source>();

        //public static string ShowSources()
        //{
        //string sourceString = string.Empty;

        // foreach (var source in sources)
        // {
        // sourceString = string.Format("New Source Added - {0}", source.SourceName);

        //Console.WriteLine(string.Format("New Source Added - {0}", source.SourceName));
        // }
        //return sourceString;
        //}
        #endregion
    }
}
