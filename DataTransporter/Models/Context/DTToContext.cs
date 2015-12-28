using DataTransporter.Models.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataTransporter.Models.Context
{
    public class DTToContext : DbContext
    {
        public DbSet<InventoryFeeds> InventoryFeeds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DTToContext>(null);
            
            //tabloları -s takısı ile oluşturmasını önlemek için . Bunun yerine entity de table ismi verildi 
            

            //Configure domain classes using Fluent API here
            //base.OnModelCreating(modelBuilder); 
        }


    }
}