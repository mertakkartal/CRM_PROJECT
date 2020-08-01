using CRM_Project.DAL.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CRM_Project.DAL.Context
{
    public class CRMContext : DbContext
    {
        public CRMContext() : base("CRMProject")
        {
        }

        public DbSet<Login> logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}