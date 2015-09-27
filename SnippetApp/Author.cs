using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetApp
{
    /// <summary>
    /// This class will store Author information
    /// </summary>
   public class Author
    {
        #region Properties
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        [Key]
        public int AuthorID { get; set; }
        #endregion

        #region Methods
      
        #endregion

    }
}
