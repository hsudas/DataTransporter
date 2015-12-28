using DataTransporter.Models.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataTransporter.Models.Context
{
    public class DTFromContext : DbContext
    {
        public DbSet<InventoryFeeds> InventoryFeeds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DTFromContext>(null);
            //Database.SetInitializer<DTFromContext>(new DropCreateDatabaseIfModelChanges<DTFromContext>());
            //tabloları -s takısı ile oluşturmasını önlemek için . Bunun yerine entity de table ismi verildi 
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Configure domain classes using Fluent API here
            //base.OnModelCreating(modelBuilder); 
        }




    }
}