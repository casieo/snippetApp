using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetApp
{
    public  class Helper
    {
        private static bool a;

        public static List<Snippet> SearchForSnippets(string query)
        {
            using (var context = new SnippetAppCodeFirstDBAzure())
            {
                var q = context.Snippets.AsQueryable();
                string qs = query;
                {
                    q = q.Where(x => x.Text.Contains(qs));
                }
                var result = context.Snippets.ToList();
                return result;
            }
        }

        public static Snippet CreateKb(string text, string pageOrLocation)//, string sourceName, string sourceTypeName, string authorFirstName, string authorLastName, string comment = "Default comment")
        {
            using (var db = new SnippetAppCodeFirstDBAzure())
            {
                Snippet sp = new Snippet();
                sp.Text = text;
                sp.PageorLocation = pageOrLocation;
                db.Snippets.Add(sp);

                //Source sourcevar = new Source();
                //sourcevar.SourceName = sourceName;
                //db.Sources.Add(sourcevar);

                //Comments commentsvar = new Comments();
                //commentsvar.CommentsText = comment;
                //if (comment != "Default comment")
                //{

                //}
                //db.Comments.Add(commentsvar);

                //SourceType sourcetypevar = new SourceType();
                //sourcetypevar.SourceTypeName = sourceTypeName;
                //db.SoureTypes.Add(sourcetypevar);

                //Author authorvar = new Author();
                //authorvar.AuthorFirstName = authorFirstName;
                //authorvar.AuthorLastName = authorLastName;
                //db.Authors.Add(authorvar);

                db.SaveChanges();
                return sp;

            }
        }
            public static Snippet EditKb(string text, string pageOrLocation)//, string sourceName, string sourceTypeName, string authorFirstName, string authorLastName, string comment = "Default comment")
        {
            using (var db = new SnippetAppCodeFirstDBAzure())
            {
                Snippet sp = new Snippet();
                sp.Text = text;
                sp.PageorLocation = pageOrLocation;
                db.Snippets.Add(sp);
                db.SaveChanges();
                return sp;

            }
        }

        public static Snippet DeleteKb(string text, string pageOrLocation)//, string sourceName, string sourceTypeName, string authorFirstName, string authorLastName, string comment = "Default comment")
        {
            using (var db = new SnippetAppCodeFirstDBAzure())
            {
                Snippet sp = new Snippet();
                sp.Text = text;
                sp.PageorLocation = pageOrLocation;
                db.Snippets.Remove(sp);
                db.SaveChanges();
                return sp;

            }
        }
        //everything below was added after 10.4 class
        public static Author[] GetAllAuthors(int authorID)
        {
            using (var db = new SnippetAppCodeFirstDBAzure())
            { var authorlist = db.Authors.Where(a => a.AuthorID == authorID);
                return authorlist.ToArray();
            }
        }

        public static Snippet GetSnippetByID(int TextID)
        {
            using (var db = new SnippetAppCodeFirstDBAzure())
            {
                var snippetlist = db.Snippets.Where(a => a.TextID == TextID).FirstOrDefault();
                return snippetlist;
            }

        }
        //public static Snippet[] GetAllSnippets(string keyword)
        //{
        //    using (var db = new SnippetAppCodeFirstDBAzure())
        //    {
        //        var snippetlist = db.Snippets.Where(a => a.Text. );
        //        return snippetlist.ToArray();
        //    }
        //}
    }



      //  public static Source AddSource(string SourceName)
        //{
          //  using (var db = new SnippetAppCodeFirstDB2())
            //{
              //  Source source = new Source(SourceName);
                //source.SourceID = SourceId;
                //sources.Add(source);
                //db.Sources.Add(source);
                //db.SaveChanges();
                //return source;
           // }

       // }
       // public static void AddSourceType(string SourceType)
        //{ }
        //public static void DeleteSourceType(string SourceType)
        //{ }
        //public static void AddComments(string Comments)
        //{ }
        //public static void DeleteComments(string Comments)
        //{ }

        //public static void AddAuthor(string AuthorName)
        //{ }
        //public static void DeleteAuthor(string AuthorName)
        //{ }
        //public static void AddSnippet(string SnippetText)
        //{ }
        //public static void DeleteSnippet(string SnippetText)
        //{ }
        //#region old code
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
       // #endregion
    }


