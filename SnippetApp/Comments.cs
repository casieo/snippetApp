using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetApp
{
    /// <summary>
    /// This class will store comments about / related to the text/snippets
    /// </summary>
    public class Comments
    {
        #region Properties
        public string CommentsText { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentsID { get; set; }
        #endregion

        #region Methods
      
        #endregion

    }
}
