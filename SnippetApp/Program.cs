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
        {//This creates records, is commented out so I can test querying for records
         // CreateKb(string text, string pageOrLocation, string sourceName, string sourceTypeName, string authorFirstName, string authorLastName, string comment = "Default comment")
         //Helper.CreateKb("Testing again and again and again2", "location", "Book2", "Book", "Casie", "Owen");
            Console.WriteLine("***Wecloem to SnippetApp***");
            Console.Write("Please enter an author ID:");
            var authorid = Console.ReadLine();
            int convertedAuthorID;
            if (int.TryParse(authorid, out convertedAuthorID) == true)
            {
                var authors = Helper.GetAllAuthors(convertedAuthorID);
                //for (int i = 0; i < accounts.Length; i++)
                {
                    Console.WriteLine("Name:{0}", convertedAuthorID);
                }
            }
        }

    }

}
    

