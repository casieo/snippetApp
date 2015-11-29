using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetApp
{/// <summary>
/// This will be the class that stores the actual snippets of text.
/// </summary>
    public class Snippet
    {
        #region Properties
        public string Text { get; set; }

        public string PageorLocation { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TextID { get; set; }

        public class GetSnippets
        {
            public IQueryable<Snippet> SearchForSnippets(string query)
            {
                using (var db = new SnippetAppCodeFirstDBAzure())
                {
                    var q = db.Snippets.AsQueryable();
                    string qs = query;
                    {
                        q = q.Where(x => x.Text.Contains(qs));
                    }
                    return (q);
                }
            }
        }

        //public string sourceName { get; set; }
        //public string sourceTypeName { get; set; }
        //public string authorFirstName { get; set; }
        //public string authorLastName { get; set; }
        //public string comment { get; set; }

        #endregion

        #region Methods

        #endregion
    }
}
