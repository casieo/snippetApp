using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetApp
{
    /// <summary>
    /// This will store information about the source of the text/snippet
    /// </summary>
    public class Source
    {
        #region Properties
        public string SourceName { get; set; }

        public SourceType TypeOfSource { get; set; }
        [Key]
        public int SourceID { get; set; }

        #endregion Properties

        #region Methods


        #endregion

        #region Constructors

        public Source(string Source)
        { }
        #endregion
    }

}
            

        ///public void DeleteSource(string SourceName)
   /// {
      
    
///}
