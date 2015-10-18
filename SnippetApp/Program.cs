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
            bool success = false;
            short attempts = 1;
            Console.WriteLine("***Welcome to SnippetApp***");
            while (!success && attempts++ < 4)
            {
                Console.Write("Please enter an author ID:");
                var authorid = Console.ReadLine();
                int convertedAuthorid;
                if (int.TryParse(authorid, out convertedAuthorid) == true)
                {
                    var authors = Helper.GetAllAuthors(convertedAuthorid);
                    for (int i = 0; i < authors.Length; i++)
                    {
                        //enumerate through the list of accounts
                        if (!success)
                        {
                            //Mark it as a successful attempt
                            success = true;
                        }
                        //print a meaningful index to the user
                        Console.WriteLine("{0}. Name: {1}", i + 1, authors[i].AuthorLastName);
                    }
                    if (success)
                    {
                        //Let's ask the user for the account to pull up the details
                        Console.Write("Please select an Author: ");
                        var accountIndex = Console.ReadLine();
                        int convertedAccountIndex;
                        if (int.TryParse(accountIndex, out convertedAccountIndex) == true)
                        {
                            var author = authors[convertedAccountIndex - 1];
                            Console.WriteLine("Author Last Name: {0}, Author First Name: {1}, AuthorID: {2}",
                                author.AuthorLastName, author.AuthorFirstName, author.AuthorID);
                            Console.ReadLine();
                        }
                    }
                }
            }

        }
    }
}
    

