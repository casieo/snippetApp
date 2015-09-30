namespace SnippetApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SnippetAppCodeFirstDBAzure : DbContext
    {
        // Your context has been configured to use a 'SnippetAppCodeFirstDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SnippetApp.SnippetAppCodeFirstDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SnippetAppCodeFirstDB' 
        // connection string in the application configuration file.
        public SnippetAppCodeFirstDBAzure()
            : base("name=SnippetAppCodeFirstDBAzure")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Snippet> Snippets { get; set; }
        public virtual DbSet<SourceType> SoureTypes { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}