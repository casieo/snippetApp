using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SnippetApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // CreateKb(string text, string pageOrLocation, string sourceName, string sourceTypeName, string authorFirstName, string authorLastName, string comment = "Default comment")
            Helper.CreateKb("And yet another", "location2", "Book2", "Book", "Brandon", "Schuller" );
     
        }
    }



}
    

