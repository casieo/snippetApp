using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int SourceTypeID { get; set; }
        #endregion

        #region Methods
        
        #endregion
    }
}
