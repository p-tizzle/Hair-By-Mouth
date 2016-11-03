namespace hairByMouth2.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration.Conventions;


    public class HairContext : DbContext
    {
        // Your context has been configured to use a 'HairContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'hairByMouth2.Data.HairContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HairContext' 
        // connection string in the application configuration file.
        public HairContext()
            : base("name=HairContext")
        {
        }

       
        

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Models.EntryModel> EntryModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

