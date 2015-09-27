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
        #endregion

        #region Methods

        #endregion
    }
}
