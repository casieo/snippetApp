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
    /// This will store information about the type of source the source of the text/snippet is.
    /// </summary>
    public class SourceType
    {
        #region Properties
        public string SourceTypeName { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SourceTypeID { get; set; }
        #endregion

        #region Methods
        
        #endregion
    }
}
